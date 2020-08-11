/**
Author : Alexandre Bernard
**/

using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    #region Variables
    public int moveSpeed;
    public float spawnDelay;
    public GameObject box;

    public GameObject miniGame;
    public Phone phone;

    float nextSpawnTime;
    int speed;

    float winTime;
	#endregion

	#region Unity Methods

    void Update()
    {
        transform.localPosition = new Vector3(Mathf.PingPong(Time.time * speed, 3) - 1.5f, 1.5f,3f);
        if (Time.time > nextSpawnTime && Input.GetMouseButtonDown(0))
        {
            GameObject spawned = GameObject.Instantiate(box,transform.parent);
            spawned.transform.position = transform.position;
            spawned.GetComponent<Renderer>().material.color = Random.ColorHSV();
            nextSpawnTime = Time.time + spawnDelay;
            winTime = Time.time + 3;
        }

        if(winTime != 0 && Time.time > winTime)
        {
            CheckWin();
        }
    }

    public void GameOver()
    {
        speed = 0;
        nextSpawnTime = Time.time + 1000000;
        DestroyBoxes();
    }

    void DestroyBoxes()
    {
        foreach (GameObject box in GameObject.FindGameObjectsWithTag("Box"))
        {
            GameObject.Destroy(box);
        }
    }

    public void Init()
    {
        speed = moveSpeed;
        nextSpawnTime = 0f;
    }

    void CheckWin()
    {
        float height = -10;
        foreach (GameObject box in GameObject.FindGameObjectsWithTag("Box"))
        {
            float boxHeight = box.GetComponent<Renderer>().bounds.max.y;
            if (boxHeight > height)
            {
                height = boxHeight;
            }
        }
        if (height > 0.4)
        {
            Win();
        }
    }

    void Win()
    {
        GameObject.Destroy(miniGame);
        phone.Win();
    }

	#endregion
}