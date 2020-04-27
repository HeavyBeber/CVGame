/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class FinalScreen : MonoBehaviour
{
	#region Variables
	#endregion

	#region Unity Methods
	
    public void ContinueClick()
    {
		gameObject.SetActive(false);
    }

	public void ExitClick()
	{
		Application.Quit();
	}

	#endregion
}
