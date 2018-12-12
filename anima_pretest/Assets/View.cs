using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour {

    GameObject sphere;
    Text text;

    RaycastHit hit;

	// Use this for initialization
	void Start () {
        sphere = GameObject.Find("Sphere");
        text = GameObject.Find("Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 directin = sphere.transform.position - transform.position;

        transform.rotation = Quaternion.LookRotation(directin, Vector3.up);

		if(Physics.Raycast(transform.position,directin,out hit)){

            if (hit.collider.gameObject == sphere)
            {
                text.text = "Find";
            }
            else
            {
                text.text = "Not Find";
            }

        }
	}
}
