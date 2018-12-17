using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    protected int count;
    private int n;
    SpriteManager spriteManager;

    void Start()
    {
        spriteManager = new SpriteManager();
    }

    void Update()
    {

    }

    public void OnClick()
    {
        count++;

        n = count % 100;

        if (n == 0)
        {
            spriteManager.SpriteManage(count);
        }

        Debug.Log(count);
    }

}
