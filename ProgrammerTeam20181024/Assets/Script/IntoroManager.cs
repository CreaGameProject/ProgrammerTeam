using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntoroManager : MonoBehaviour
{

    string[] TalkText =
        {
        "(運命とは常に残酷な物だ。)",
        "(私の積み上げてきたものはロビカスによって粉々に引き裂かれてしまった。)",
        "(しかし私は諦めなかった。)",
        "いつか必ずこの悔しさを晴らすために努力をし続けてきた・・・！！！"
        };

    int TextNum = 0;

    // Use this for initialization
    void Start()
    {
        //GameObject.Find("SEManager").SendMessage("Wind");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Talk();
        }
    }

    void Talk()
    {
        Text text;
        if (TextNum <= 3)
        {
            text = this.GetComponent<Text>();
            text.text = TalkText[TextNum];
            /*if (TextNum == 2)
            {
                GameObject.Find("SEManager").SendMessage("Hyun");
            }*/
            TextNum++;
            //GameObject.Find("Chara").SendMessage("Anim");
        }
        else
        {
            SceneManager.LoadScene("Talk");
        }
    }
}
