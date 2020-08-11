/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class GeneralUI : MonoBehaviour
{
	#region Variables
	public GameObject inventoryUI;
	public GameObject playerStatsUI;
	public GameObject questUI;
	public PlayerController playerController;
	#endregion

	#region Unity Methods
	public void ToggleStatAndInventory()
	{
		questUI.SetActive(false);

		inventoryUI.SetActive(!inventoryUI.activeSelf);
		playerStatsUI.SetActive(!playerStatsUI.activeSelf);

		playerController.canMove = !inventoryUI.activeSelf;
	}
	public void ToggleQuest()
	{
		questUI.SetActive(!questUI.activeSelf);

		inventoryUI.SetActive(false);
		playerStatsUI.SetActive(false);

		playerController.canMove = !questUI.activeSelf;
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
