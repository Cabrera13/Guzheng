using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
	public AudioClip p;
	AudioSource s;
	public Text t;
	public Button un;
	public Button dos;
	public Button tres;
	public Button canc;
	public Button menys;
	string n;
	string j;
	public Animator anim;

	bool start = false;
	// Use this for initialization
	void Start () {
		un.gameObject.SetActive (false);
		dos.gameObject.SetActive (false);
		tres.gameObject.SetActive (false);
		t.gameObject.SetActive (false);
		canc.gameObject.SetActive (false);
		menys.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void clickPlay () {
		un.gameObject.SetActive (true);
		dos.gameObject.SetActive (true);
		tres.gameObject.SetActive (true);
		t.gameObject.SetActive (true);
		canc.gameObject.SetActive (true);
		menys.gameObject.SetActive (true);
		bool start = true;
	}
	public void removeLast () {
		try {
		n = t.text;
		n = n.Substring (0, n.Length - 1);
		t.text = n;
		}
		catch (UnityException e) {
			Debug.Log (e);
		}
	}
	public void cancelar () {
		un.gameObject.SetActive (false);
		dos.gameObject.SetActive (false);
		tres.gameObject.SetActive (false);
		t.text = "";
		t.gameObject.SetActive (false);
		canc.gameObject.SetActive (false);
		menys.gameObject.SetActive (false);
		bool start = false;

	}
	public void startGame() {
		if (start == true && t.text == "123" || PlayerPrefs.GetInt("es") == 1) {
			PlayerPrefs.SetInt ("es", 1);
			anim.SetTrigger ("play");
			s.PlayOneShot (p);
			Invoke ("load", 2);
		}
	}
	public void load () {
		SceneManager.LoadScene ("GameScene");
	}
}
