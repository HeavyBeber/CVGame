/**
Author : Alexandre Bernard
**/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightBulb : MonoBehaviour
{
    #region Variables
    bool active = false;
    public List<LightBulb> neighbours;
    LightBulbs parent;

    float completedAtTime;
    float completionSpeed = .1f;
    #endregion

    #region Unity Methods
    public void Start()
    {
        parent = GameObject.FindObjectOfType<LightBulbs>();
        parent.onComplete += Complete;
    }

    void Update()
    {
        transform.GetComponent<Image>().color = active ? Color.white : Color.grey;

        if (completedAtTime > 0)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1), (Time.time - completedAtTime) * completionSpeed);
        }
    }

    public void Switch()
    {
        active = !active;
    }

    public bool IsActive()
    {
        return active;
    }
    public void OnClick()
    {
        Switch();
        parent.Click(neighbours);
    }
    public void Complete(float completionTime)
    {
        completedAtTime = completionTime;
        GetComponent<Button>().enabled = false;
    }

    #endregion
}