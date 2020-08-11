/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class BlackBoard : Interactable
{
	#region Variables
	public GameObject blackboardUI;
	public ParticleSystem completionEffect;
	public GameObject ejectionPoint;
	public Collectable equipmentReleased;

	public PlayerController playerController;
	public GameObject nextObject;
	#endregion

	#region Unity Methods
	public override void Interact()
	{
		base.Interact();
		blackboardUI.SetActive(true);
		playerController.canMove = false;
	}

	public void CompleteQuest()
	{

		gameObject.SetActive(false);
		Destroy(Instantiate(completionEffect.gameObject) as GameObject, 2);

		nextObject.SetActive(true);

		equipmentReleased.transform.position = ejectionPoint.transform.position;
		Instantiate(equipmentReleased, ejectionPoint.transform.position, ejectionPoint.transform.rotation);
		playerController.canMove = true;
	}

	#endregion
}
