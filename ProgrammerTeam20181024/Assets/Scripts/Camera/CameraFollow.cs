using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;        //カメラが追従する座標
    public float smoothing = 5f;    //カメラが追従する速度

    Vector3 offset;                 //

    // Use this for initialization
	void Start () {
         offset = transform.position - target.position;
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        //ターゲットからのカメラの基本となる位置
        Vector3 targetCamPos = target.position + offset;

        //カメラとターゲット間でのスムーズな動き
        transform.position = Vector3.Lerp(transform.position,targetCamPos,smoothing * Time.deltaTime);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
