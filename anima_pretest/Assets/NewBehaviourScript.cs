using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    GameObject viewer;
    public float speed;

	// Use this for initialization
	void Start () {
        viewer = GameObject.Find("Viewer");
	}
	
	// Update is called once per frame
	void Update () {

        transform.RotateAround(viewer.transform.position, Vector3.up, speed);

	}
}
