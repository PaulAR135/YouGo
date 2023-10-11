using System.Collections.Generic;
using MetaYouGo.Scripts.Prizes;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Transform ItemInventorySlotParent;
    [SerializeField] private GameObject ItemInventorySlot;

    // TODO: save to scriptable object
    private List<Prize> PrizesInInventory = new List<Prize>();
    
    void Start()
    {
        
    }

    public void AddPrizeToInventory(Prize _prize)
    {
        PrizesInInventory.Add(_prize);
        
        GameObject slot = Instantiate(ItemInventorySlot, ItemInventorySlotParent);
        slot.transform.GetChild(0).GetComponent<Image>().sprite = _prize.PrizeSprite;
    }
}
