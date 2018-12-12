using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

    // Use this for initialization
    public GameObject cube;
	void Start () {
        float fi = -4.5f;
        for(int i = 0; i < 10; i++)
        {
            float fj = 0.5f;
            for(int j = 0; j < 10; j++)
            {
                float fk = -4.5f;
                for(int k = 0; k < 10; k++)
                {
                    Instantiate(cube, new Vector3(fi, fj, fk), Quaternion.identity);
                    fk+=1f;
                }
                fj+=1f;
            }
            fi += 1f; ;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
