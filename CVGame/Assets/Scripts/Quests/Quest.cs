/**
Author : Alexandre Bernard
**/

using UnityEngine;

[CreateAssetMenu(fileName = "New quest", menuName = "Quests/quest")]
public class Quest : ScriptableObject
{
    #region Variables

    public string title;
    [TextArea(15, 20)]
    public string text;
    public string year;
	#endregion

	#region Unity Methods

	#endregion
}
