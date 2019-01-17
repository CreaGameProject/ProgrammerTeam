using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour {

    public ScoreTe scoreText;
    public TimerTe timerText;
    [SerializeField]
    private Transform targetObj; 
    public static float time = 30;

    // Use this for initialization
    void Start () {
        timerText.GetComponent<TimerTe>().time1 = time;
    }
	
	// Update is called once per frame
	void Update () {

        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        Transform Play = this.transform;
        Vector3 posi = Play.position;
        Vector3 distance = targetObj.transform.position;
        float po = posi.x-distance.x;
        scoreText.GetComponent<ScoreTe>().score = po;
        timerText.GetComponent<TimerTe>().time1 = time;

    }

}
