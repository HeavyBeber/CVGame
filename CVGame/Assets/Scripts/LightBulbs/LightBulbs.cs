/**
Author : Alexandre Bernard
**/

using System.Collections.Generic;
using UnityEngine;

public class LightBulbs : MonoBehaviour
{
    #region Variables
    public LightBulb[] lightBulbs;

    float completionTime;

    public delegate void OnComplete(float completionTime);
    public OnComplete onComplete;

    public Quests quests;
    #endregion

    #region Unity Methods

    public void Update()
    {
        if (completionTime > 0 && Time.time > 5 + completionTime)
        {
            GameObject.FindObjectOfType<Satellite>().CompleteQuest();
            GameObject.Destroy(gameObject);
        }
    }

    public void Click(List<LightBulb> neighbours)
    {
        foreach (LightBulb lightbulb in neighbours)
        {
            lightbulb.Switch();
        }


        if (CheckCompletion())
        {
            CompletePuzzle();
        }
    }

    bool CheckCompletion()
    {
        for (int i = 0; i < 9; i++)
        {
            if (!lightBulbs[i].IsActive())
            {
                return false;
            }
        }
        return true;
    }

    void CompletePuzzle()
    {
        completionTime = Time.time;
        onComplete.Invoke(completionTime);
        quests.CompleteQuest();
    }
    #endregion
}