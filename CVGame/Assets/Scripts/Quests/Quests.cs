/**
Author : Alexandre Bernard
**/

using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{
    
    #region Variables
    public QuestSlot[] questSlots;
    int currentQuestIndex = 0;
    public Text currentYear;
    public GameObject notif;
    public GameObject finalScreen;
    #endregion

    #region Unity Methods
    private void Start()
    {
        questSlots[0].gameObject.SetActive(true);
    }

    public void CompleteQuest()
    {
        questSlots[currentQuestIndex].CompleteQuest();
        currentQuestIndex++;
        if (questSlots.Length > currentQuestIndex)
        {
            questSlots[currentQuestIndex].gameObject.SetActive(true);
            currentYear.text = questSlots[currentQuestIndex].quest.year;
            notif.gameObject.SetActive(true);
        } 
        else
        {
            gameObject.SetActive(false);
            Inventory.instance.gameObject.SetActive(false);
            finalScreen.SetActive(true);
        }
    }

	#endregion
}
