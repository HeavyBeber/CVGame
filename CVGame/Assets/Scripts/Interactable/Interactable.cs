using UnityEngine;

public class Interactable : MonoBehaviour
{
	#region Variables
    public float radius = 3f;
	public Transform interactionTransform;

	bool isFocused = false;
	bool hasInteracted = false;
	Transform player;
	#endregion

	#region Unity Methods

	public virtual void Interact()
	{
		Debug.Log("Interact with : " + transform.name);
	}

	private void Update()
	{
		if (isFocused && !hasInteracted)
		{
			float distanceToPlayer = Vector3.Distance(interactionTransform.position, player.position);

			if (distanceToPlayer < radius)
			{
				Interact();
				hasInteracted = true;
			}
		}
	}

	public void OnFocused(Transform playerTransfom)
	{
		isFocused = true;
		hasInteracted = false;
		player = playerTransfom;
	}

	public void OnDeFocused()
	{
		isFocused = false;
		hasInteracted = false;
		player = null;
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(interactionTransform.position, radius);
	}
	#endregion
}
