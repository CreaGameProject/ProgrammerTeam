using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private float speed;
    [SerializeField] private float zoom;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, -speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward*zoom);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back*zoom);
        }
    }
}
