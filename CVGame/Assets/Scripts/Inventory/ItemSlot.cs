﻿/**
Author : Alexandre Bernard
**/

using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
	#region Variables
	public Image icon;
	public Button removeButton;
	Item item;
	#endregion

	#region Unity Methods

	public void AddItem(Item newItem)
	{
		item = newItem;
		icon.sprite = item.icon;
		icon.enabled = true;
		removeButton.interactable = true;
	}

	public void ClearSlot()
	{
		item = null;
		icon.sprite = null;
		icon.enabled = false;
		removeButton.interactable = false;
	}

	public void OnRemoveButton()
	{
		UseItem();
		Inventory.instance.Remove(item);
	}

	public void UseItem()
	{
		if (item != null)
		{
			item.Use();
		}
	}

	#endregion
}
