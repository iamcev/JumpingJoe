using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

	public GameObject[] obstacles;
	private Transform jjt;
	private float SpawnY = 0.0f;
	private float Dist = 8.0f;
	private int ObstaclesOnScreen = 6;
	private int LastObInd = 0;

	private List<GameObject> activeObstacle;

	// Use this for initialization
	void Start () {
		activeObstacle = new List<GameObject> ();
		jjt = GameObject.FindGameObjectWithTag ("Player").transform;
		for(int i = 0; i < ObstaclesOnScreen; i++) {
			MakeObstacle();
		}
   	} 

	// Update is called once per frame
	void Update () {
		if (jjt.position.y - 15.0f > SpawnY - ObstaclesOnScreen * Dist) {
			MakeObstacle ();
			DeleteObstacle ();
		}
			
	}

	private void MakeObstacle(int obind = -1) {
		GameObject o;
		o = Instantiate (obstacles [RandomObstacle()]) as GameObject;
		o.transform.SetParent (transform);
		o.transform.position = new Vector3(0, SpawnY, 0);
		SpawnY += Dist;
		activeObstacle.Add (o);
	} 
	private void DeleteObstacle() {
		Destroy (activeObstacle [0]);
		activeObstacle.RemoveAt (0);
	}

	private int RandomObstacle() {
		if (obstacles.Length <= 1) {
			return 0;
		}
		int Rand = LastObInd;
		while (Rand == LastObInd) {
			Rand = Random.Range (0, obstacles.Length);
		}
		LastObInd = Rand;
		return Rand;
	}
}
