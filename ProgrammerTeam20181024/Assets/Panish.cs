using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panish : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        float time2 = Sample.time;
        if (time2 < 2)
        {
            gameObject.SetActive(false);
        }
    }
}
