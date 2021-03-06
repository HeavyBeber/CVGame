﻿/**
Author : Alexandre Bernard
**/

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StatHolder : MonoBehaviour
{
	#region Variables
	public Image icon;
	public string statName;
	public int statValue;

	Color originalColor;
	#endregion

	#region Unity Methods
	void Start()
	{
		originalColor = transform.Find("StatValue").GetComponent<Text>().color;
		transform.Find("StatName").GetComponent<Text>().text = statName;
		transform.Find("StatValue").GetComponent<Text>().text = statValue.ToString();
	}

	public void UpdateUI(int value)
	{
		Text statValue = transform.Find("StatValue").GetComponent<Text>();
		statValue.text = value.ToString();
		if (statValue.IsActive())
		{
			StartCoroutine(UpdateColor());
		}
	}

    IEnumerator UpdateColor()
    {
        float percent = 0;

		while (percent <= 2)
		{
			percent += Time.deltaTime * 8;
			float interpolation = Mathf.Abs(Mathf.Sin(2f* Mathf.PI * percent));

			transform.Find("StatValue").GetComponent<Text>().color = Color.Lerp(originalColor, Color.red, interpolation);

			yield return null;
		}

		transform.Find("StatValue").GetComponent<Text>().color = originalColor;
	}
    #endregion
}
