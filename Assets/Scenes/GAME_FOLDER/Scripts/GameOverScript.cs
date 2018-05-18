using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour {

	public Text FinalScore;

	// Use this for initialization
	void Start () {
		FinalScore.text = "Score: " + PlayerPrefs.GetFloat ("Score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Play () {
		SceneManager.LoadScene ("jumpinjoe");
	}
	public void Menu () {
		SceneManager.LoadScene ("startmenu");
	}
}
