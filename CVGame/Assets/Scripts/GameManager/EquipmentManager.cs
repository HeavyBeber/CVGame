/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
	#region Singleton
	public static EquipmentManager instance;
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
	Equipment[] equipments;
	Inventory inventory;

	public delegate void OnEquipmentChange(Equipment newItem, Equipment oldItem);
	public OnEquipmentChange onEquipmentChange;
	#endregion

	#region Unity Methods
	void Start() {
		inventory = Inventory.instance;
		int numberOfSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
		equipments = new Equipment[numberOfSlots];
    }

	public void Equip(Equipment equipment)
	{
		int slotIndex = (int)equipment.slot;

		Equipment oldItem = equipments[slotIndex];

		if (oldItem != null)
		{
			inventory.Add(oldItem);
		}
		
		equipments[slotIndex] = equipment;

		if (onEquipmentChange != null)
		{
			onEquipmentChange.Invoke(equipment, oldItem);
		}
	}

	public void Unequip(int slotIndex)
	{
		Equipment equipedItem = equipments[slotIndex];

		if (equipedItem != null)
		{
			inventory.Add(equipedItem);
			equipments[slotIndex] = null;

			if (onEquipmentChange != null)
			{
				onEquipmentChange.Invoke(null, equipedItem);
			}
		}
	}

	public void UnequipAll()
	{
		for (int i = 0; i < equipments.Length; i++)
		{
			Unequip(i);
		}
	}

	public void Update()
	{
		if (Input.GetButtonDown("Unequip all items"))
		{
			UnequipAll();
		}
	}
	#endregion
}
