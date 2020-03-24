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
	#endregion

	#region Unity Methods
	void Start()
	{
		((Text) transform.Find("StatName").GetComponent("Text")).text = statName;
		((Text) transform.Find("StatValue").GetComponent("Text")).text = statValue.ToString();

		Inventory.instance.onItemChangeCallback += UpdateUI;
	}

	private void UpdateUI()
	{
		((Text)transform.Find("StatValue").GetComponent("Text")).text = statValue.ToString();
		StartCoroutine(UpdateColor());
	}

    IEnumerator UpdateColor()
    {
        Color originalColor = ((Text)transform.Find("StatValue").GetComponent("Text")).color;

        float percent = 0;

        while (percent <= 1)
        {
            percent += Time.deltaTime;
            float interpolation = (-percent * percent + percent) * 4;

            ((Text)transform.Find("StatValue").GetComponent("Text")).color = Color.Lerp(originalColor, Color.red, interpolation);

            yield return null;
        }
    }
    #endregion
}
