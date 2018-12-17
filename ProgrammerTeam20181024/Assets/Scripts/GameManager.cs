using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if (count == 510)
        {
            SceneManager.LoadScene("BaseBall");
        }

        Debug.Log(count);
    }

}
