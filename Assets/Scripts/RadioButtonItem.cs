using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadioButtonItem : MonoBehaviour, IButton {

	[SerializeField] private Animator _animator;

	private const string IsSelectedParam = "IsSelected";

	public UnityEvent OnSelected = new UnityEvent ();

	public void UnSelect() 
	{
		_animator.SetBool (IsSelectedParam, false);
	}

	public void Select() 
	{
		OnSelected.Invoke ();
		_animator.SetBool (IsSelectedParam, true);
	}


}
