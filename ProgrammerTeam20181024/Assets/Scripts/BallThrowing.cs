using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrowing : MonoBehaviour {

    [SerializeField]
    GameObject ballPrefab;

    [SerializeField]
    Transform pitcher;

    [SerializeField]
    float ballPower = 500f;

    bool throwing = false;
    float throwingTime;

    [SerializeField]
    float time = 10f;

    // Use this for initialization
    void Start ()
    {
        throwingTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time - throwingTime >= time)
        {
            throwing = true;
            if (throwing == true)
            {
                BallThrow();
                throwingTime = Time.time;
                throwing = false;
            }



        }

      
    }

    private void BallThrow()
    {
        Vector3 controllerA = new Vector3(0,0.1f,1);
        var ballInstance = GameObject.Instantiate(ballPrefab, pitcher.position, pitcher.rotation) as GameObject;

        int ballWay = Random.Range(1,3);

        switch (ballWay)
        {
            case 1:
            ballInstance.GetComponent<Rigidbody>().AddForce(ballInstance.transform.forward * ballPower);
                break;

            case 2:
            ballInstance.GetComponent<Rigidbody>().AddForce(ballInstance.transform.forward * ballPower *8);
                break;

            case 3:
                ballInstance.GetComponent<Rigidbody>().AddForce(ballInstance.transform.forward * ballPower);
                break;

            case 4:
            ballInstance.GetComponent<Rigidbody>().AddForce(ballInstance.transform.forward * ballPower);

                break;
        }

       // ballInstance.GetComponent<Rigidbody>().AddForce(ballInstance.transform.forward * ballPower);

    }

    private void BallClear()
    {
        
    }
}
