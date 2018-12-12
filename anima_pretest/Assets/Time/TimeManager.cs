using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	// Use this for initialization
    [SerializeField]private float timescale;
    private bool slow;
	void Start () {
        slow = false;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("速度変化");
        if (Input.GetKeyDown(KeyCode.Z))
        {
            slow = !slow;
        }
        if (slow)
        {
            Time.timeScale = timescale;
        }
        else
        {
            Time.timeScale = 1f;
        }
        if (Input.GetKey(KeyCode.X))
        {
            Time.timeScale = 0;
        }
    }
}
