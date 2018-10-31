using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    float x;
    float y;
    float z;

    public int gravityPower = 15;

    Vector3 localGravity;
   
    Rigidbody rb;
    
    // Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        GravityController();
        localGravity.x = x;
        localGravity.y = y;
        localGravity.z = z;
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
        Vector3 pos = transform.position;
        Vector3 defG = new Vector3(0,0,0);

       float xDis = defG.x - pos.x;
       float yDis = defG.y - pos.y;
       float zDis = defG.z - pos.z;

        float direction = Mathf.Sqrt(gravityPower/(xDis * xDis + yDis * yDis + zDis * zDis));
        x = direction * xDis;
        y = direction * yDis;
        z = direction * zDis;
    }
}
