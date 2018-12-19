using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattingManager : MonoBehaviour {

    bool swing;
    bool swingEnd;

    public float speed = 1000f;

    Quaternion homePos;

	// Use this for initialization
	void Start ()
    {
        swing = false;
        homePos = transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            swingEnd = false;
            swing = true;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            swing = false;
            swingEnd = true;
        }
	}

    private void FixedUpdate()
    {
        if (swing == true)
        {
            BatSwing();
        }

        if (swingEnd == true)
        {
            Stanby();

        }
    }

    private void BatSwing()
    {
        float step = speed * Time.deltaTime;
        //Debug.Log("カウント");
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 180f, 0), step);
    }

    private void Stanby()
    {
        float step = speed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), step);

    }


    private void BantController()
    {


    }
}
