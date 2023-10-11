using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup InventoryCanvasGroup;

    private bool InventoryEnabled;

    private void Start()
    {
        InventoryEnabled = false;
    }

    public void ShowInventory()
    {
        InventoryEnabled = !InventoryEnabled;
        InventoryCanvasGroup.alpha = (InventoryEnabled) ? 1.0f : 0.0f;
        InventoryCanvasGroup.interactable = InventoryEnabled;
        InventoryCanvasGroup.blocksRaycasts = InventoryEnabled;
    }
}
