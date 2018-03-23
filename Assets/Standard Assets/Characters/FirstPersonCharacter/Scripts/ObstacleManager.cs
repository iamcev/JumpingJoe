using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {
	public GameObject[] obstacles;
	private float spawnY = 0.0f;
	private float distance = 5.0f;
	private int obstaclesOnScreen = 5;
	private int LastObstacle = 0; 
	public GameObject player; 

	// Use this for initialization
	void Start () {
		for (int i = 0; i < obstaclesOnScreen; i++) {
			MakeNewObstacle ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.y > (spawnY - obstaclesOnScreen * distance)) {
			MakeNewObstacle ();
		}
	}

	void MakeNewObstacle() {
		GameObject go;
		go = Instantiate (obstacles [RandomObstacle()]) as GameObject;
		go.transform.SetParent (transform);
		if (go.name == "Simple_Obstacle") {
			go.transform.position = Vector3.up * spawnY;
			go.transform.position = Vector3.right * 3.0f;
			spawnY += distance * 2;
		} else if (go.name == "Another_Simple_Obstacle"){
			go.transform.position = Vector3.up * spawnY * distance;
			go.transform.position = Vector3.left * 3.0f;
			spawnY += distance * 2;
		}
		spawnY += distance * 2;
	}
	private int RandomObstacle() {
		if (obstacles.Length <= 1) {
			return 0;
		}
		int RandomO = LastObstacle;
		while (RandomO == LastObstacle) {
			RandomO = Random.Range(0, obstacles.Length);
		}
		LastObstacle = RandomO;
		return RandomO;
	}
}
