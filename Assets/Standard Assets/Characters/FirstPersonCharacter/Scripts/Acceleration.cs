using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Acceleration : MonoBehaviour {
	public Text meters; 
    public float a = 0.18f;
    public float dc = -0.08f;
    public float v = 0.00f;
    public int t = 0;
	public float q = -6;
    public bool Accelerating {
        get
        {
            return Input.GetKey("space");
		}
    }

	// Use this for initialization
	void Start () 
	{
	}

    // Update is called once per frame
    void Update()
    {
        if (Accelerating)
        {
            t++;
        }
        else if(t > 0)
        {
            t--;
        }
		var movHoriz = -(Input.GetAxis("Horizontal"));
		var z = gameObject.name.Equals ("Main Camera") ? 25f : 0f;
		transform.position = new Vector3 (movHoriz, (v + (a) * t * t) / 10 - q, z + q);
		meters.text = t.ToString() + "m";
		if (t > 1000)
		{
			meters.text = (t / 1000).ToString() + "km"; 
		}
    }
}
