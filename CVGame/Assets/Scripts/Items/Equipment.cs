/**
Author : Alexandre Bernard
**/

using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
	#region Variables

	#region Backend
	public int javaModifier;
	public int cSharpModifier;
	public int unityModifier;
	public int springModifier;
	public int restModifier;
	public int dockerModifier;
	public int testingModifier;
	#endregion
	#region Database
	public int mongoModifier;
	public int sqlModifier;
	#endregion
	#region Methodology
	public int agileModifier;
	public int safeModifier;
	#endregion
	#region Frontend
	public int angularModifier;
	public int webLanguagesModifier;
	public int electronModifier;
	#endregion
	#region ConfigManagement
	public int pcfModifier;
	public int mavenModifier;
	public int gitModifier;
	#endregion
	#region Tools
	public int atlassianModifier;
	public int eclipseModifier;
	public int vsCodeModifier;
	public int officeModifier;
	public int adobeModifier;
	public int blenderModifier;
	#endregion
	#region Misc
	public int englishModifier;
	public int ageOfEmpire2DEModifier;
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

public enum EquipmentSlot {Backend, Database, Methodology, Frontend, ConfigManagment, Tools, Miscalleneous}
