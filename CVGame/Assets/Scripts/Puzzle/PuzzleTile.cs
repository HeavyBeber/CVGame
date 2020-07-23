/**
Author : Alexandre Bernard
**/

using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleTile : MonoBehaviour
{
    #region Variables
    public int targetPosition;
    Puzzle parent;
    bool isSelected;

    float completedAtTime;
    float completionSpeed = .1f;
	#endregion

	#region Unity Methods
	public void Start()
    {
        parent = GameObject.FindObjectOfType<Puzzle>();
        parent.onComplete += Complete;
    }

	public void onClick()
    {
        isSelected = !isSelected;
        parent.Click(targetPosition);
    }

    public void Update()
    {
        transform.GetComponent<Image>().color = isSelected ? Color.gray : Color.white;

        if (completedAtTime > 0)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1), (Time.time - completedAtTime) * completionSpeed);
        }
    }

    public void Unselect()
    {
        isSelected = false;
    }

    public void Complete(float completionTime)
    {
        completedAtTime = completionTime;
        GetComponent<Button>().enabled = false;
    }
	#endregion
}