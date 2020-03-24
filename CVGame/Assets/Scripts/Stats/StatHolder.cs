/**
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
		originalColor = ((Text)transform.Find("StatValue").GetComponent("Text")).color;
		((Text) transform.Find("StatName").GetComponent("Text")).text = statName;
		((Text) transform.Find("StatValue").GetComponent("Text")).text = statValue.ToString();
	}

	public void UpdateUI(int value)
	{
		((Text)transform.Find("StatValue").GetComponent("Text")).text = value.ToString();
		StartCoroutine(UpdateColor());
	}

    IEnumerator UpdateColor()
    {
        float percent = 0;

        while (percent <= 1)
        {
            percent += Time.deltaTime * 8;
            float interpolation = (-percent * percent + percent) * 4;

            ((Text)transform.Find("StatValue").GetComponent("Text")).color = Color.Lerp(originalColor, Color.red, interpolation);

            yield return null;
		}

		percent = 0;

		while (percent <= 1)
		{
			percent += Time.deltaTime * 8;
			float interpolation = (-percent * percent + percent) * 4;

			((Text)transform.Find("StatValue").GetComponent("Text")).color = Color.Lerp(originalColor, Color.red, interpolation);

			yield return null;
		}

		percent = 0;

		while (percent <= 1)
		{
			percent += Time.deltaTime * 8;
			float interpolation = (-percent * percent + percent) * 4;

			((Text)transform.Find("StatValue").GetComponent("Text")).color = Color.Lerp(originalColor, Color.red, interpolation);

			yield return null;
		}
	}
    #endregion
}
