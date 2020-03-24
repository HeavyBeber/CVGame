/**
Author : Alexandre Bernard
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat 
{
    #region Variables
	[SerializeField]
    private int baseValue = 0;
	[SerializeField]
	private StatHolder statHolder = null;

	public delegate void OnStatChanged(int value);
	public OnStatChanged onStatChanged;

	private List<int> modifiers = new List<int>();
	#endregion

	#region Unity Methods
	public StatHolder GetStatHolder()
	{ 
		return statHolder;
	}

	public int GetValue()
	{
		int finalValue = baseValue;
		modifiers.ForEach(x => finalValue += x);

		return finalValue;
	}

	public void AddModifier(int modifier)
	{
		if (modifier != 0)
		{
			modifiers.Add(modifier);
			if (onStatChanged != null)
			{
				onStatChanged.Invoke(this.GetValue());
			}
		}
	}

	public void RemoveModifier(int modifier)
	{
		if (modifier != 0)
		{
			modifiers.Remove(modifier);
			if (onStatChanged != null)
			{
				onStatChanged.Invoke(this.GetValue());
			}
		}
	}
	#endregion
}
