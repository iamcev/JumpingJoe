using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDuck : MonoBehaviour {

	Transform jj;
	private Vector3 pos;	

	// Use this for initialization
	void Start () {
		pos = transform.position;
		jj = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		pos.x = 0; 
		pos.y = jj.position.y;
	}
}
