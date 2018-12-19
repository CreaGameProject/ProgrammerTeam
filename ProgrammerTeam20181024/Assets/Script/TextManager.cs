using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

    string[] TalkText = 
        {
        "(全てはこの時のために、努力をしてきたんだ！！！)",
        "うおおおおおおおおおおおおおお",
        "(必ず打ってみせるっ！！！！)"
        };

    int TextNum = 0;

	// Use this for initialization
	void Start () {
        //GameObject.Find("SEManager").SendMessage("Wind");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Talk();
        }
    }

    void Talk()
    {
        Text text;
        if (TextNum <= 2)
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
            SceneManager.LoadScene("Main");
        }
    }
}
