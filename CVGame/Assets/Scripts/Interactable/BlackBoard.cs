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
	#endregion

	#region Unity Methods
	public override void Interact()
	{
		base.Interact();


		blackboardUI.SetActive(true);

	}

	public void CompleteQuest()
	{

		gameObject.SetActive(false);
		Destroy(Instantiate(completionEffect.gameObject) as GameObject, 2);

		equipmentReleased.transform.position = ejectionPoint.transform.position;
		Instantiate(equipmentReleased, ejectionPoint.transform.position, ejectionPoint.transform.rotation);
	}

	#endregion
}
