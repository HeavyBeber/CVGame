/**
Author : Alexandre Bernard
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	#region Singleton
	public static Inventory instance;
	private void Awake()
	{
		if (instance != null)
		{
			Debug.LogWarning("More than one instance of Inventory found");
			return;
		}
		instance = this;
	}
	#endregion

	#region Variables
    public List<Item> items = new List<Item>();
	public int inventorySize = 20;

    #region Event 
	public delegate void OnItemChange();
    public OnItemChange onItemChangeCallback;
	# endregion

	#endregion

	#region Unity Methods

	public bool Add(Item item)
	{
		if(!item.isDefaultItem)
		{
			if (items.Count >= inventorySize)
			{
				Debug.Log("Not enough item room in Inventory");
				return false;
			}			
			items.Add(item);

			if (onItemChangeCallback != null)
				onItemChangeCallback.Invoke();
		}
		return true;
	}

	public void Remove(Item item)
	{
		items.Remove(item);

		if (onItemChangeCallback != null)
			onItemChangeCallback.Invoke();
	}
	#endregion
}
