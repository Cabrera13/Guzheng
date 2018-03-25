using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InpCode : MonoBehaviour {
	public Text mainInputField;

	public void Start()
	{
		
	}

	public void enter1() {
		Debug.Log ("hola");

		mainInputField.text += "1";
	}
	public void enter2() {
		mainInputField.text += "2";
	}
	public void enter3() {
		Debug.Log ("hola");
		mainInputField.text += "3";
	}
}
