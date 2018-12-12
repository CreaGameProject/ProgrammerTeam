using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    public Vector3 localGravity;
    Vector3 stand;
    Vector3 pos;

    private Rigidbody rb;
    private float x;
    private float y;
    private float z;

    private float yxRad;
    private float yzRad;
    private float zxRad;

    //public object Quartanion { get; private set; }

    // Use this for initialization
    void Start() {

        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        GravityController();

        localGravity.x = x;
        localGravity.y = y;
        localGravity.z = z;

        CharaMoving();//キャラ移動のメソッド
        CharaStandingVector();//キャラを地面に対して垂直に立たせる       
    }

    private void FixedUpdate()
    {
        SetLocalGravity();
        //CharaMoving();
    }

    private void SetLocalGravity()
    {
        rb.AddForce(localGravity, ForceMode.Acceleration);
    }

    private void GravityController()
    {
        //x = localGravity.x;
        //y = localGravity.y;
        //z = localGravity.z;

        pos = transform.position;
        Vector3 basePoint = new Vector3(0, 0, 0);

        float xDistance = basePoint.x - pos.x;
        float yDistance = basePoint.y - pos.y;
        float zDistance = basePoint.z - pos.z;

        float direction = Mathf.Sqrt(100 / (xDistance * xDistance + yDistance * yDistance + zDistance * zDistance));

        x = direction * xDistance;
        y = direction * yDistance;
        z = direction * zDistance;

        Vector3 normalVector = new Vector3(x, y, z);
    }

    private void CharaStandingVector()
    {
        pos = transform.position;
        Vector3 basePoint = new Vector3(0, 0, 0);
        stand = pos - basePoint;
        Vector3 cameraPos = GameObject.Find("Camera").transform.position;
        Vector3 fowardMoving = pos - cameraPos;

        Quaternion rotation = Quaternion.LookRotation(fowardMoving, stand);
        transform.rotation = rotation;

        //yxRad = Mathf.Atan(pos.x / pos.y);
        //yzRad = Mathf.Atan(pos.z / pos.y);
        //zxRad = Mathf.Atan(pos.x / pos.z);

        //if (pos.y == 0)
        //{
        //    yxRad = Mathf.PI / 2;
        //    yzRad = Mathf.PI / 2;
        //}
        //else if (pos.z == 0)
        //{
        //    zxRad = Mathf.PI / 2;
        //}

        //yxRad = yxRad * Mathf.Rad2Deg;
        //yzRad = yzRad * Mathf.Rad2Deg;
        //zxRad = zxRad * Mathf.Rad2Deg;

        //Debug.Log("yxRad = " + yxRad);
        //Debug.Log("yxRad = " + yzRad);
        //Debug.Log("zxRad = " + zxRad);

        //Quaternion stand = Quaternion.Euler(yzRad, zxRad, yxRad);
        //transform.localRotation = stand;//算出した角度を代入
    }

    private void CharaMoving()
    {
        pos = transform.position;

        Vector3 cameraPos = GameObject.Find("Camera").transform.position;
        Vector3 fowardMoving = pos - cameraPos;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(fowardMoving * 30);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 30);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 30);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(fowardMoving * (-1) * 30);
        }
    }
}


