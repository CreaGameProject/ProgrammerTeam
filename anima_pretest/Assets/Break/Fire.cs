using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private float speed;
    Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);

        }
    }
}
