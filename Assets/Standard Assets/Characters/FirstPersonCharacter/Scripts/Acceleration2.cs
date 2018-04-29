using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Acceleration2 : MonoBehaviour {
    float delta = 0f;
    float height = 0f;
    const float incr = 0.02f;
    bool Accelerating
    {
        get
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                if (Input.touchCount > 0)
                {
                    return true;
                }
            }
            return Input.GetKey("space");
        }
    }
    // Use this for initialization
    void Start () {
        delta = 0f;
        height = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if(this.Accelerating)
        {
            delta += incr;
        } else
        {
            delta -= incr;
        }
        height += delta;
        if (height <= 0)
        {
            height = 0f;
            delta = 0f;
        }
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }
}
