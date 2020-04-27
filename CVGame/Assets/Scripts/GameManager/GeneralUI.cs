/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class GeneralUI : MonoBehaviour
{
	#region Variables
	public GameObject inventoryUI;
	public GameObject playerStatsUI;
	public GameObject QuestUI;
	#endregion

	#region Unity Methods
	public void ToggleStatAndInventory()
	{
		QuestUI.SetActive(false);

		inventoryUI.SetActive(!inventoryUI.activeSelf);
		playerStatsUI.SetActive(!playerStatsUI.activeSelf);
	}
	public void ToggleQuest()
	{
		QuestUI.SetActive(!QuestUI.activeSelf);

		inventoryUI.SetActive(false);
		playerStatsUI.SetActive(false);
	}

	void Update()
	{
		if (Input.GetButtonDown("Inventory"))
		{
			ToggleStatAndInventory();
		}

		if (Input.GetButtonDown("Quest"))
		{
			ToggleQuest();
		}
	}
	#endregion
}
