using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Acceleration : MonoBehaviour {
    public Text meters;
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

    short LeftRightModifier
    {
         get
        {
            if(Input.GetKey("left"))
            {
                return 1;
            }
            else if (Input.GetKey("right"))
            {
                return -1;
            }
            return 0;
        }
    }

    public GameObject JumpingJoe;

	// Use this for initialization
	void Start () 
	{
        delta = 0f;
        height = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.Accelerating)
        {
            delta += incr;
        }
        else
        {
            delta -= incr;
        }
        height += delta;
        if (height <= 0)
        {
            height = 0f;
            delta = 0f;
        }
		var movHoriz = Input.mousePosition.x;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var z = gameObject.name.Equals("Main Camera") ? 25f : 0f;
        var x = transform.position.x + LeftRightModifier * incr * 5;
        if (x > 17)
        {
            x = 17;
        } else if (x < -17)
        {
            x = -17;
        }
		transform.position = new Vector3(x, height, transform.position.z);
		meters.text = height.ToString() + "m";
        Debug.Log(transform.position);
		if (height > 1000)
		{
			meters.text = (height / 1000).ToString() + "km"; 
		}
		

    }	

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Obstacle") {
			Restart();
			Debug.Log("flajf");
		} 
	}

	void Restart() {
		transform.position = new Vector3 (0, 0, 0);
	} 

}
