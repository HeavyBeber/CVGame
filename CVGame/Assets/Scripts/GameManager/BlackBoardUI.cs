/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class BlackBoardUI : MonoBehaviour
{
	#region Variables
	public Quests quests;
	public BlackBoard blackboard;
	#endregion

	#region Unity Methods
	
	public void TextChanged(string text)
	{
		int number = int.Parse(text);
		if (number == 42)
		{
			quests.CompleteQuest();
			gameObject.SetActive(false);
			blackboard.CompleteQuest();
		}
	}

	#endregion
}
