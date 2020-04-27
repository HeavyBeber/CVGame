/**
Author : Alexandre Bernard
**/

using UnityEngine;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{
    
    #region Variables
    public QuestSlot[] questSlots;
    int currentQuestIndex;
    public Text currentYear;
    public GameObject finalScreen;
    #endregion

    #region Unity Methods
    private void Start()
    {
        currentQuestIndex = 0;
    }

    public void CompleteQuest()
    {
        questSlots[currentQuestIndex].quest.isCompleted = true;
        questSlots[currentQuestIndex].quest.isActive = false;

        currentQuestIndex++;
        if (questSlots.Length > currentQuestIndex)
        {
            questSlots[currentQuestIndex].gameObject.SetActive(true);
            questSlots[currentQuestIndex].quest.isActive = true;
            currentYear.text = questSlots[currentQuestIndex].quest.year;
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
