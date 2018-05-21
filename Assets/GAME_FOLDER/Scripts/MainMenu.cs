using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour {

	public Text HiScTe;
	private float Score;
	private float LastScore;

	// Use this for initialization
	void Start () {
		Score = PlayerPrefs.GetFloat ("Score");
	}

	// Update is called once per frame
	void Update () {
		HiScTe.text = "Highscore: " + Score.ToString();
	}

	public void Play () {
		SceneManager.LoadScene ("jumpinjoe");
	}
	public void Closet() {
		SceneManager.LoadScene ("closet");
	}
}
