using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    private GameObject player;
    
    private KeyCode rightRotate = KeyCode.RightArrow;
    private KeyCode leftRotate = KeyCode.LeftArrow;
    private float rotateSpeed = 5f;
    private float rotate;
    private float rotateMim;
    private float rotateMax;
    private float rotateAccel;
    private bool rotating;

    // Use this for initialization
    void Awake () {
        player = GameObject.FindWithTag("Player");
	}

    // Update is called once per frame
    void Update()
    {
        rotateAccel += Time.deltaTime;
        CameraRotate();
        if (rotating==false)
        {
            CameraTweak();
        }
    }


    //カメラの左右回転
    private void CameraRotate()
    {
        if (Input.GetKeyDown(rightRotate))
        {
            rotateMim = 0;
            rotateMax = -rotateSpeed;
            rotateAccel = 0;
        }
        if (Input.GetKeyUp(rightRotate))
        {
            rotateMim = -rotateSpeed;
            rotateMax = 0;
            rotateAccel = 0;
        }
        if (Input.GetKeyDown(leftRotate))
        {
            rotateMim = 0;
            rotateMax = rotateSpeed;
            rotateAccel = 0;
        }
        if (Input.GetKeyUp(leftRotate))
        {
            rotateMim = rotateSpeed;
            rotateMax = 0;
            rotateAccel = 0;
        }
        float t = rotateAccel * 2.5f;
        rotate = Mathf.Lerp(rotateMim, rotateMax, t);
        transform.RotateAround(player.transform.position, Vector3.up, rotate);
        rotating = (rotate < -0.2f | 0.2f < rotate) ? true : false;
    }


    //正面を向ける微調整
    private void CameraTweak()
    {
        float abjust = transform.eulerAngles.y < 180f ? transform.eulerAngles.y : transform.eulerAngles.y - 360f;
        if (((Input.GetKey(rightRotate) | Input.GetKey(leftRotate)) == false)
            & (-30f < abjust & abjust < 30f))
        {
            transform.RotateAround(player.transform.position, Vector3.up, abjust * -0.1f);
        }
    }
}
