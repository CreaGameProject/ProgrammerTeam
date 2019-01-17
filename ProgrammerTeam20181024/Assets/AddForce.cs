using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

   public float power = 5.0f;
   public bool atack1 = false;
   public bool atack2 = true;
    //public Rigidbody rb;

    IEnumerator Attack()
    {
        atack2 = false;
        yield return new WaitForSeconds(0.7f);
        power+=10;
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(power, power, 0);
        rb.AddForce(force, ForceMode.Impulse);
        yield return new WaitForSeconds(0.7f);
        atack2 = true;
    }

	// Use this for initialization
	void Start () {
		//Rigidbody rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float timeratack = Sample.time;
        if (Input.GetKeyDown(KeyCode.Space)&&atack1==true&&timeratack>0)
        {
            Debug.Log("青ブタ");
            if (atack2)
            {
               StartCoroutine(Attack());
            }
            
        }


	}
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            atack1 = true;            
        }
    }
    void OnTriggerExit(Collider co)
    {
        if(co.gameObject.tag=="Player")
        {
            atack1 = false;
        }
    }
}
