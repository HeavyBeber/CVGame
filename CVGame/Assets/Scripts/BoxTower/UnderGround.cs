/**
Author : Alexandre Bernard
**/

using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UnderGround : MonoBehaviour
{
    #region Variables
    public int life;
	int currentLife = 0;
	public BoxSpawner boxSpawner;
	public Text text;
	public GameObject endScreen;
	#endregion

	#region Unity Methods
	void OnCollisionEnter(Collision collision)
	{
		GameObject.Destroy(collision.gameObject);
		currentLife--;
		text.text = "Life left : " + currentLife;
	}

	void Update()
	{
		if (currentLife == 0)
		{
			GameOver();
		}
	}

	void GameOver()
	{
		boxSpawner.GameOver();
		endScreen.SetActive(true);
	}

	public void Init()
	{
		boxSpawner.Init();
		currentLife = life;
		endScreen.SetActive(false);
		text.text = "Life left : " + currentLife;
	}
	#endregion
}