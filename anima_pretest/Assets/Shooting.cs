using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject bullet;

    public Transform muzzle;

    [SerializeField] private float speed = 1000;

    public float survival_time = 5;

    public float time;

	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time>1f)
        {
            GameObject bullets = Instantiate(bullet) as GameObject;

            Vector3 force;

            force = this.gameObject.transform.forward * speed;

            bullets.GetComponent<Rigidbody>().AddForce(force);

            bullets.transform.position = muzzle.position;

            Destroy(bullets, survival_time);

            time = 0;
        }


	}
}
