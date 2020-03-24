/**
Author : Alexandre Bernard
**/

using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
	#region Variables

	#region Misc
	public int englishModifier;
	public int ageOfEmpire2DEModifier;
	#endregion
	#region Backend
	public int javaModifier;
	public int cSharpModifier;
	public int unityModifier;
	public int springModifier;
	public int testingModifier;
	public int restModifier;
	#endregion
	#region Frontend
	public int angularModifier;
	public int webLanguagesModifier;
	public int electronModifier;
	#endregion
	#region Database
	public int mongoModifier;
	public int sqlModifier;
	#endregion
	#region ConfigManagement
	public int mavenModifier;
	public int gitModifier;
	#endregion
	#region Ops
	public int dockerModifier;
	public int pcfModifier;
	#endregion
	#region Tools
	public int atlassianModifier;
	public int eclipseModifier;
	public int vsCodeModifier;
	public int officeModifier;
	public int adobeModifier;
	public int blenderModifier;
	#endregion
	#region Methodology
	public int agileModifier;
	public int safeModifier;
	#endregion

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

public enum EquipmentSlot {Backend, Frontend, Database, ConfigManagment, Ops, Tools, Methodology, Miscalleneous}
