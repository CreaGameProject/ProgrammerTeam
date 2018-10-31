using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        moveSpeed = ( moveSpeed == 0 ) ? 100 : moveSpeed;
    }

    void Start()
    {

    }

    void Update()
    {
        GetKey();
    }

    private void GetKey()
    {
        float x = Input.GetAxis( "Horizontal" ) * Time.deltaTime;
        float z = Input.GetAxis( "Vertical" ) * Time.deltaTime;

        if ( x != 0 || z != 0 )
        {
            Move( x, z );
        }
    }

    private void Move( float x, float z )
    {
        rb.AddForce( x * moveSpeed, 0, z * moveSpeed );
    }
}
