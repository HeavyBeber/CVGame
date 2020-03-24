﻿/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    #region Variables
    Inventory inventory;
    public Transform itemsParent;
    ItemSlot[] itemSlots;
    public GameObject inventoryUI;
    public GameObject playerStatsUI;
    #endregion

	#region Unity Methods
    void Start() 
    {
        inventory = Inventory.instance;
        inventory.onItemChangeCallback += UpdateUI;

        itemSlots = itemsParent.GetComponentsInChildren<ItemSlot>();
    }

    void Update() 
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            playerStatsUI.SetActive(!playerStatsUI.activeSelf);
        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                itemSlots[i].AddItem(inventory.items[i]);
            } else
            {
                itemSlots[i].ClearSlot();
            }
        }
    }
	#endregion
}
