/**
Author : Alexandre Bernard
**/

using System;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    private const int NONE = -1;
    #region Variables
    public PuzzleTile[] puzzleTiles;
    int selected = NONE;

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
            GameObject.FindObjectOfType<Exam>().CompleteQuest();
            GameObject.Destroy(gameObject);
        }
    }
    void UnselectAll()
    {
        foreach (PuzzleTile pTile in puzzleTiles)
        {
            pTile.Unselect();
        }
    }

    int FindTileWithId(int id)
    {
        int i = 0;
        foreach (PuzzleTile pTile in puzzleTiles)
        {
            if (pTile.targetPosition == id)
            {
                return i;
            }
            i++;
        }
        return -1;
    }

    public void Click(int id)
    {

        if (selected != NONE)
        {
            int firstTile = FindTileWithId(selected);
            int secondTile = FindTileWithId(id);
            Vector3 previousPosition = puzzleTiles[firstTile].transform.position;

            puzzleTiles[firstTile].transform.position = puzzleTiles[secondTile].transform.position;
            puzzleTiles[secondTile].transform.position = previousPosition;

            PuzzleTile temp = puzzleTiles[firstTile];
            puzzleTiles[firstTile] = puzzleTiles[secondTile];
            puzzleTiles[secondTile] = temp;

            UnselectAll();
            selected = NONE;
            
            if (CheckCompletion())
            {
                CompletePuzzle();
            }
        }
        else
        {
            selected = id;

        }
    }

    bool CheckCompletion()
    {
        for (int i = 0; i < 9; i++)
        {
            if (puzzleTiles[i].targetPosition != i)
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
        quests.CompleteQuest();
    }

	#endregion
}