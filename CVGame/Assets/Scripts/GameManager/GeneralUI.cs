/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class GeneralUI : MonoBehaviour
{
	#region Variables
	public GameObject inventoryUI;
	public GameObject playerStatsUI;
	#endregion

	#region Unity Methods
	public void ToggleUIs()
	{
		inventoryUI.SetActive(!inventoryUI.activeSelf);
		playerStatsUI.SetActive(!playerStatsUI.activeSelf);
	}
	#endregion
}
