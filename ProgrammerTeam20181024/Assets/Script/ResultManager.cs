using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SetScore();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }
    }
    //スコアの反映
    void SetScore()
    {
        int scoreNum;
        string scoreText;
        Text text;

        //スコアを取得、反映
        scoreNum = PlayerPrefs.GetInt("Score",0);
        scoreText = scoreNum.ToString();

        text = GameObject.Find("ScoreText").GetComponent<Text>();
        text.text = scoreText;
    }
}
