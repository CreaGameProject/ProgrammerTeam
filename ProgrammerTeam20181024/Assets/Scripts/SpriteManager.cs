using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [SerializeField] GameObject honey;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SpriteManage(int num)
    {
        num = num / 100;
        Instantiate(Resources.Load("Honey"), new Vector3( num * 2 - 1, -0.5f, 0f), Quaternion.identity);
    }
}
