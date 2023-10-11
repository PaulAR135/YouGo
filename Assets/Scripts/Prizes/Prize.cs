using System;
using System.Collections;
using MetaYouGo.Scripts.Server;
using UnityEngine;
using UnityEngine.UI;
using You.Facade.Proxies.v1;

namespace MetaYouGo.Scripts.Prizes
{
    // TODO:
    // just an initial template
    
    public class Prize : MonoBehaviour
    {
        public int CollectedDistance;
        public ulong PrizeID;
        public ulong BasketID;
        public Double PrizeLatitude, PrizeLongitude;
        public Vector3 PrizePosition;
        public Sprite PrizeSprite;
        public uint MaxPerksPerPeer;

        private ServerConnector ServerConnector;
        private PrizeController PrizeController;
        private Inventory Inventory;
        private Button PrizeButton;
        private uint PrizeCollected;
        private bool Collected;

        private Camera mainCamera;
        private IEnumerator CheckDistance;

        private void Start()
        {
            ServerConnector = GameObject.FindWithTag("WorldContainer").GetComponent<ServerConnector>(); // TODO: don't need opportunity to use ServerConnector here! only in PrizeController or similar scripts
            PrizeController = GameObject.FindObjectOfType<PrizeController>();
            Inventory = GameObject.FindWithTag("Inventory").GetComponent<Inventory>();
            PrizeButton = transform.GetComponentInChildren<Button>();
            PrizeCollected = 0;
            
            mainCamera = Camera.main;
            
            CheckDistance = CheckDistanceCoroutine();
            StartCoroutine(CheckDistance);
        }

        private IEnumerator CheckDistanceCoroutine()
        {
            while (true)
            {
                // can't collect prize, it's too far
                Vector3 cameraPoint = mainCamera.transform.position;
                Vector3 prizePoint = new Vector3(transform.position.x, cameraPoint.y, transform.position.z);

                if (Vector3.Distance(cameraPoint, prizePoint) > CollectedDistance)
                    PrizeButton.interactable = false;
                else
                    PrizeButton.interactable = true;

                yield return new WaitForSeconds(0.5f);
            }
        }

        public async void LockPrizeByMyself()
        {
            bool locked = await ServerConnector.LockPrizeAsync(PrizeID);
            if (locked) TakePrizeToMyInventory();

            TakePrizeToMyInventory();
        }

        private void TakePrizeToMyInventory()
        {
            Inventory.AddPrizeToInventory(this);
            
            PrizeCollected++;
            if (PrizeCollected >= MaxPerksPerPeer)
            {
                PrizeController.DeletePrizeInBasketByID(this.BasketID);
            }
            
            StopCoroutine(CheckDistance);
            Destroy(gameObject);
        }
    }
}