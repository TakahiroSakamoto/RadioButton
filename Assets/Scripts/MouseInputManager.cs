using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputManager : MonoBehaviour 
{
	private RaycastHit hit;

	
	// Update is called once per frame
	void Update () 
	{
		if (!Input.GetMouseButtonDown (0)) return;

		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (!Physics.Raycast (ray, out hit)) return;

		var button = hit.collider.GetComponent<IButton>();
		if (button == null) return;
		button.Select ();	
	}
}
