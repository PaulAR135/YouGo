using System.Collections.Generic;
using MetaYouGo.Scripts.Player;
using MetaYouGo.Scripts.Server;
using UnityEngine;
using UnityEngine.UI;
using You.Facade.Proxies.v1;
using LatLng = Google.Maps.Coord.LatLng;

namespace MetaYouGo.Scripts.Prizes
{
    public class PrizeController : MonoBehaviour
    {
        public ServerConnector ServerConnector;
        public PlayerCameraController PlayerCameraController;
        public GameObject PrizeIconGameObject;
        public Inventory PrizeInventory;

        private List<Basket> baskets = new List<Basket>();
        private List<PrizeByBasketResponse> prizes = new List<PrizeByBasketResponse>();
        private List<HistoryResponse> prizesInventory = new List<HistoryResponse>();
        
        private LatLng CurrentLatLng;
        
        void Start()
        {
            // TODO: hot test fix
            Invoke("Initialization", 2);
        }
        
        // TODO: delay for getting current gps coordinates
        // have to be event after getting gps coordinates
        private void Initialization()
        {
            CurrentLatLng = ServerConnector.BaseMapLoader.LatLng;
            InitPrizesOnMap();
            InitPrizesInInventory();
        }

        // TODO: need to separete prizes by basket GameObjects, it can be easy to find and manipulate
        public void DeletePrizeInBasketByID(ulong _basketID)
        {
            if (transform.childCount > 0)
            {
                foreach (Transform prize in transform)
                {
                    if (prize.GetComponent<Prize>().BasketID == _basketID)
                        Destroy(prize.gameObject);
                }
            }
        }

        // TODO: move method to separate class
        private async void InitPrizesInInventory()
        {
            prizesInventory.Clear();
            prizesInventory = await ServerConnector.GetPrizesInInventory();

            foreach (var prizeInventory in prizesInventory)
            {
                Texture2D texture = await ServerConnector.GetTextureByURL(prizeInventory.IconUrl);
                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                Prize prize = new Prize();
                prize.PrizeID = prizeInventory.Id;
                prize.PrizeSprite = sprite;
                
                PrizeInventory.AddPrizeToInventory(prize);
            }
        }
        
        private async void InitPrizesOnMap()
        {
            // delete previous prizes
            // TODO: update only new prizes
            if (transform.childCount > 0)
            {
                foreach (Transform oldPrizeObject in transform)
                {
                    Destroy(oldPrizeObject.gameObject);
                }
            }
            
            // get
            baskets.Clear();
            baskets = await ServerConnector.GetBasketsAsync(CurrentLatLng);

            // instantiate
            // baskets
            foreach (var basket in baskets)
            {
                Texture2D texture = await ServerConnector.GetTextureByURL(basket.IconUrl);
                Sprite basketSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                prizes.Clear();
                prizes = await ServerConnector.GetPrizesAsync(basket);

                // prizes
                foreach (var basketPrize in prizes)
                {
                    GameObject prizeGameObject = Instantiate(PrizeIconGameObject, transform);
                    Prize prize = prizeGameObject.GetComponent<Prize>();

                    prize.BasketID = basket.BasketId;
                    prize.PrizeID = basketPrize.Id;
                    prize.PrizeLatitude = basketPrize.Latitude;
                    prize.PrizeLongitude = basketPrize.Longitude;
                    prize.PrizeSprite = basketSprite;
                    prize.MaxPerksPerPeer = basket.MaxPerksPerPeer;
                    
                    LatLng latLng = new LatLng(prize.PrizeLatitude, prize.PrizeLongitude);
                    prize.PrizePosition = ServerConnector.MapsService.Projection.FromLatLngToVector3(latLng);

                    prizeGameObject.GetComponent<RectTransform>().position = prize.PrizePosition;
                    prizeGameObject.GetComponentInChildren<Image>().sprite = prize.PrizeSprite;
                }
            }
        }

        private void OnEnable()
        {
            PlayerCameraController.OnPositionChanged += InitPrizesOnMap;
        }

        private void OnDisable()
        {
            PlayerCameraController.OnPositionChanged -= InitPrizesOnMap;
        }
        
        // TODO: need to create ScriptableObject = PrizesDataBase and download/collect there all prizes
    }
}