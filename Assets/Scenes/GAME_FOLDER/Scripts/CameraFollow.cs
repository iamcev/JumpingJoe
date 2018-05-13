using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject Joe;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - Joe.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = Joe.transform.position + offset;
    }
}
