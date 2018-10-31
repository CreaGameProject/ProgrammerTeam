using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {


    Vector3 localGravity;
   
    Rigidbody rb;
    
    // Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        SetLocalGravity();   
    }

    void SetLocalGravity()
    {
        rb.AddForce(localGravity, ForceMode.Acceleration);
    }

    private void GravityController()
    {
       
    }
}
