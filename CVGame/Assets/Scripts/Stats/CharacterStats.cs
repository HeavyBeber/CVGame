/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class CharacterStats : MonoBehaviour
{
	#region Variables
	#region Backend
	public Stat java;
	public Stat cSharp;
	public Stat unity;
	public Stat spring;
	public Stat rest;
	public Stat docker;
	public Stat testing;
	#endregion
	#region Database
	public Stat mongo;
	public Stat sql;
	#endregion
	#region Methodology
	public Stat agile;
	public Stat safe;
	#endregion
	#region Frontend
	public Stat angular;
	public Stat webLanguages;
	public Stat electron;
	#endregion
	#region ConfigManagement
	public Stat pcf;
	public Stat maven;
	public Stat git;
	#endregion
	#region Tools
	public Stat atlassian;
	public Stat eclipse;
	public Stat vsCode;
	public Stat office;
	public Stat adobe;
	public Stat blender;
	#endregion
	#region Misc
	public Stat english;
	public Stat ageOfEmpire2DE;
	#endregion
	#endregion

	#region Unity Methods
	void Start() {
		EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;

		java.onStatChanged += java.GetStatHolder().UpdateUI;
		cSharp.onStatChanged += cSharp.GetStatHolder().UpdateUI;
		unity.onStatChanged += unity.GetStatHolder().UpdateUI;
		spring.onStatChanged += spring.GetStatHolder().UpdateUI;
		rest.onStatChanged += rest.GetStatHolder().UpdateUI;
		docker.onStatChanged += docker.GetStatHolder().UpdateUI;
		testing.onStatChanged += testing.GetStatHolder().UpdateUI;

		angular.onStatChanged += angular.GetStatHolder().UpdateUI;
		webLanguages.onStatChanged += webLanguages.GetStatHolder().UpdateUI;
		electron.onStatChanged += electron.GetStatHolder().UpdateUI;

		mongo.onStatChanged += mongo.GetStatHolder().UpdateUI;
		sql.onStatChanged += sql.GetStatHolder().UpdateUI;

		pcf.onStatChanged += pcf.GetStatHolder().UpdateUI;
		maven.onStatChanged += maven.GetStatHolder().UpdateUI;
		git.onStatChanged += git.GetStatHolder().UpdateUI;

		atlassian.onStatChanged += atlassian.GetStatHolder().UpdateUI;
		eclipse.onStatChanged += eclipse.GetStatHolder().UpdateUI;
		vsCode.onStatChanged += vsCode.GetStatHolder().UpdateUI;
		office.onStatChanged += office.GetStatHolder().UpdateUI;
		adobe.onStatChanged += adobe.GetStatHolder().UpdateUI;
		blender.onStatChanged += blender.GetStatHolder().UpdateUI;

		agile.onStatChanged += agile.GetStatHolder().UpdateUI;
		safe.onStatChanged += safe.GetStatHolder().UpdateUI;

		english.onStatChanged += english.GetStatHolder().UpdateUI;
		ageOfEmpire2DE.onStatChanged += ageOfEmpire2DE.GetStatHolder().UpdateUI;
	}

	void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
	{
		if (newItem != null)
		{
			java.AddModifier(newItem.javaModifier);
			cSharp.AddModifier(newItem.cSharpModifier);
			unity.AddModifier(newItem.unityModifier);
			spring.AddModifier(newItem.springModifier);
			rest.AddModifier(newItem.restModifier);
			docker.AddModifier(newItem.dockerModifier);
			testing.AddModifier(newItem.testingModifier);

			mongo.AddModifier(newItem.mongoModifier);
			sql.AddModifier(newItem.sqlModifier);

			agile.AddModifier(newItem.agileModifier);
			safe.AddModifier(newItem.safeModifier);

			angular.AddModifier(newItem.angularModifier);
			webLanguages.AddModifier(newItem.webLanguagesModifier);
			electron.AddModifier(newItem.electronModifier);

			pcf.AddModifier(newItem.pcfModifier);
			maven.AddModifier(newItem.mavenModifier);
			git.AddModifier(newItem.gitModifier);

			atlassian.AddModifier(newItem.atlassianModifier);
			eclipse.AddModifier(newItem.eclipseModifier);
			vsCode.AddModifier(newItem.vsCodeModifier);
			office.AddModifier(newItem.officeModifier);
			adobe.AddModifier(newItem.adobeModifier);
			blender.AddModifier(newItem.blenderModifier);

			english.AddModifier(newItem.englishModifier);
			ageOfEmpire2DE.AddModifier(newItem.ageOfEmpire2DEModifier);
		}
		if (oldItem != null)
		{
			java.RemoveModifier(oldItem.javaModifier);
			cSharp.RemoveModifier(oldItem.cSharpModifier);
			unity.RemoveModifier(oldItem.unityModifier);
			spring.RemoveModifier(oldItem.springModifier);
			rest.RemoveModifier(oldItem.restModifier);
			docker.RemoveModifier(oldItem.dockerModifier);
			testing.RemoveModifier(oldItem.testingModifier);

			mongo.RemoveModifier(oldItem.mongoModifier);
			sql.RemoveModifier(oldItem.sqlModifier);

			agile.RemoveModifier(oldItem.agileModifier);
			safe.RemoveModifier(oldItem.safeModifier);

			angular.RemoveModifier(oldItem.angularModifier);
			webLanguages.RemoveModifier(oldItem.webLanguagesModifier);
			electron.RemoveModifier(oldItem.electronModifier);

			pcf.RemoveModifier(oldItem.pcfModifier);
			maven.RemoveModifier(oldItem.mavenModifier);
			git.RemoveModifier(oldItem.gitModifier);

			atlassian.RemoveModifier(oldItem.atlassianModifier);
			eclipse.RemoveModifier(oldItem.eclipseModifier);
			vsCode.RemoveModifier(oldItem.vsCodeModifier);
			office.RemoveModifier(oldItem.officeModifier);
			adobe.RemoveModifier(oldItem.adobeModifier);
			blender.RemoveModifier(oldItem.blenderModifier);

			english.RemoveModifier(oldItem.englishModifier);
			ageOfEmpire2DE.RemoveModifier(oldItem.ageOfEmpire2DEModifier);
		}
	}
	#endregion
}
