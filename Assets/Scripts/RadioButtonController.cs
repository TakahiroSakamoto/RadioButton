using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadioButtonController: MonoBehaviour 
{
	[SerializeField] private List<RadioButtonItem> buttons;

	public void Start()
	{
		foreach (var button in buttons) 
		{
			button.OnSelected.AddListener (() => OnButtonClicked (button));
		}
	}

	void OnButtonClicked(RadioButtonItem button) 
	{
		foreach (var other in buttons) 
		{
			if (other != button) 
			{
				other.UnSelect();
			}
		}
	}
}
