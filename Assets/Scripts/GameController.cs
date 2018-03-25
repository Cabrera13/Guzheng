using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public AudioSource[] strings;
	public Animator[] anim;

	// Use this for initialization
	void Start () {
		try {
		SceneManager.UnloadSceneAsync ("ManuScene");
		}
		catch {
			//
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.isEditor) {
			
			if (Input.GetKeyDown (KeyCode.Alpha0)) {
				anim [0].SetTrigger ("rdy");
				strings [0].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				anim [1].SetTrigger ("rdy");
				strings [1].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				anim [2].SetTrigger ("rdy");
				strings [2].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				anim [3].SetTrigger ("rdy");
				strings [3].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				anim [4].SetTrigger ("rdy");
				strings [4].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				anim [5].SetTrigger ("rdy");
				strings [5].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				anim [6].SetTrigger ("rdy");
				strings [6].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha7)) {
				anim [7].SetTrigger ("rdy");
				strings [7].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha8)) {
				anim [8].SetTrigger ("rdy");
				strings [8].Play ();
			}
			if (Input.GetKeyDown (KeyCode.Alpha9)) {
				anim [9].SetTrigger ("rdy");
				strings [9].Play ();
			}
		} else {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				if (hit.collider.name != "Shadow Fake Plane") {
					hit.collider.gameObject.GetComponent<AudioSource> ().Play ();
					hit.collider.gameObject.GetComponent<Animator> ().Rebind ();
					hit.collider.gameObject.GetComponent<Animator> ().SetTrigger ("rdy");
				}
			}
		}

	}
	public void onclick () {
		
		SceneManager.LoadScene ("ManuScene");

	}
}
