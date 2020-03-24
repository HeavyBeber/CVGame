/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class CharacterStats : MonoBehaviour
{
	#region Variables
	#region Misc
	public Stat english;
	public Stat ageOfEmpire2DE;
	#endregion
	#region Backend
	public Stat java;
	public Stat cSharp;
	public Stat unity;
	public Stat spring;
	public Stat rest;
	public Stat docker;
	public Stat testing;
	#endregion
	#region Frontend
	public Stat angular;
	public Stat webLanguages;
	public Stat electron;
	#endregion
	#region Database
	public Stat mongo;
	public Stat sql;
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
	#region Methodology
	public Stat agile;
	public Stat safe;
	#endregion
	#endregion

	#region Unity Methods
	void Start() {
		EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
    }

	void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
	{
		if (newItem != null)
		{
			english.AddModifier(newItem.englishModifier);
			ageOfEmpire2DE.AddModifier(newItem.ageOfEmpire2DEModifier);
			java.AddModifier(newItem.javaModifier);
			cSharp.AddModifier(newItem.cSharpModifier);
			unity.AddModifier(newItem.unityModifier);
			spring.AddModifier(newItem.springModifier);
			testing.AddModifier(newItem.testingModifier);
			rest.AddModifier(newItem.restModifier);
			angular.AddModifier(newItem.angularModifier);
			webLanguages.AddModifier(newItem.webLanguagesModifier);
			electron.AddModifier(newItem.electronModifier);
			mongo.AddModifier(newItem.mongoModifier);
			sql.AddModifier(newItem.sqlModifier);
			maven.AddModifier(newItem.mavenModifier);
			git.AddModifier(newItem.gitModifier);
			docker.AddModifier(newItem.dockerModifier);
			pcf.AddModifier(newItem.pcfModifier);
			atlassian.AddModifier(newItem.atlassianModifier);
			eclipse.AddModifier(newItem.eclipseModifier);
			vsCode.AddModifier(newItem.vsCodeModifier);
			office.AddModifier(newItem.officeModifier);
			adobe.AddModifier(newItem.adobeModifier);
			blender.AddModifier(newItem.blenderModifier);
			agile.AddModifier(newItem.agileModifier);
			safe.AddModifier(newItem.safeModifier);
		}
		if (oldItem != null)
		{
			english.RemoveModifier(oldItem.englishModifier);
			ageOfEmpire2DE.RemoveModifier(oldItem.ageOfEmpire2DEModifier);
			java.RemoveModifier(oldItem.javaModifier);
			cSharp.RemoveModifier(oldItem.cSharpModifier);
			unity.RemoveModifier(oldItem.unityModifier);
			spring.RemoveModifier(oldItem.springModifier);
			testing.RemoveModifier(oldItem.testingModifier);
			rest.RemoveModifier(oldItem.restModifier);
			angular.RemoveModifier(oldItem.angularModifier);
			webLanguages.RemoveModifier(oldItem.webLanguagesModifier);
			electron.RemoveModifier(oldItem.electronModifier);
			mongo.RemoveModifier(oldItem.mongoModifier);
			sql.RemoveModifier(oldItem.sqlModifier);
			maven.RemoveModifier(oldItem.mavenModifier);
			git.RemoveModifier(oldItem.gitModifier);
			docker.RemoveModifier(oldItem.dockerModifier);
			pcf.RemoveModifier(oldItem.pcfModifier);
			atlassian.RemoveModifier(oldItem.atlassianModifier);
			eclipse.RemoveModifier(oldItem.eclipseModifier);
			vsCode.RemoveModifier(oldItem.vsCodeModifier);
			office.RemoveModifier(oldItem.officeModifier);
			adobe.RemoveModifier(oldItem.adobeModifier);
			blender.RemoveModifier(oldItem.blenderModifier);
			agile.RemoveModifier(oldItem.agileModifier);
			safe.RemoveModifier(oldItem.safeModifier);
		}

		java.UpdateStatHolder();
		cSharp.UpdateStatHolder();
		unity.UpdateStatHolder();
		spring.UpdateStatHolder();
		testing.UpdateStatHolder();
		rest.UpdateStatHolder();

		angular.UpdateStatHolder();
		webLanguages.UpdateStatHolder();
		electron.UpdateStatHolder();

		mongo.UpdateStatHolder();
		sql.UpdateStatHolder();

		maven.UpdateStatHolder();
		git.UpdateStatHolder();

		docker.UpdateStatHolder();
		pcf.UpdateStatHolder();

		atlassian.UpdateStatHolder();
		eclipse.UpdateStatHolder();
		vsCode.UpdateStatHolder();
		office.UpdateStatHolder();
		adobe.UpdateStatHolder();
		blender.UpdateStatHolder();
	}
	#endregion
}
