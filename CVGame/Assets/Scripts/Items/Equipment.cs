/**
Author : Alexandre Bernard
**/

using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
	#region Variables
	public int englishModifier;
	public EquipmentSlot slot;
	#endregion

	#region Unity Methods
	public override void Use()
	{
		base.Use();

		EquipmentManager.instance.Equip(this);
		RemoveFromInventory();
	}
	#endregion
}

public enum EquipmentSlot {Head, Chest, Legs, Weapon, Shield, Feet}
