/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class Satellite : Interactable
{
	#region Variables
	public GameObject ejectionPoint1;
	public GameObject ejectionPoint2;
	public Collectable equipmentReleased1;
	public Collectable equipmentReleased2;
	public GameObject lightBulb;

	public PlayerController playerController;
	public GameObject nextObject;
	#endregion

	#region Unity Methods
	public override void Interact()
	{
		base.Interact();
		lightBulb.SetActive(true);
		playerController.canMove = false;
	}

	public void CompleteQuest()
	{
		gameObject.SetActive(false);

		equipmentReleased1.transform.position = ejectionPoint1.transform.position;
		Instantiate(equipmentReleased1, ejectionPoint1.transform.position, ejectionPoint1.transform.rotation);
		equipmentReleased2.transform.position = ejectionPoint2.transform.position;
		Instantiate(equipmentReleased2, ejectionPoint2.transform.position, ejectionPoint2.transform.rotation);

		playerController.canMove = true;
		nextObject.SetActive(true);
	}


	#endregion
}