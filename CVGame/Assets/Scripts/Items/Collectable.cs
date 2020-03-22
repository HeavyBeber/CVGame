/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class Collectable : Interactable
{
	#region Variables
	public Item item;
	#endregion

	#region Unity Methods
	public override void Interact()
	{
		base.Interact();

		Pickup();
	}

	void Pickup()
	{
		Debug.Log("Picking up item : " + item.name);

		if (Inventory.instance.Add(item))
		{
			Destroy(gameObject);
		}
		
	}
	#endregion
}
