using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    bool getMonaca = false;
    int haveKorone = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
            //Debug.Log("Jump");
        }
	}
    //ジャンプ処理
    void Jump()
    {
        GetComponent<Animator>().SetBool("Jump",true);
        Invoke("ResetJump", 1);
    }
    void ResetJump()
    {
        GetComponent<Animator>().SetBool("Jump", false);
    }

    //チョコモナカジャンボを取った際にアニメーションをする
    void Miss()
    {
        GetComponent<Animator>().SetBool("Miss", true);
        Invoke("ResetMiss", 0.1f);
    }
    void ResetMiss()
    {
        GetComponent<Animator>().SetBool("Miss", false);
    }

    //他のオブジェクトに触れた際の処理
    void OnTriggerEnter2D(Collider2D other)
    {
        //相手オブジェクトがチョコモナカジャンボだった場合
        if (other.gameObject.tag == "Monaca")
        {
            //Debug.Log("チョコモナカジャンボ");
            getMonaca = true;
            Destroy(other.gameObject);
            GameObject.Find("SEManager").SendMessage("Monaca");
            GameObject.Find("Player").SendMessage("Miss");
        }

        //相手オブジェクトがバニラモナカジャンボだった場合
        if (other.gameObject.tag == "Vanila")
        {
            //Debug.Log("バニラモナカジャンボ");
            getMonaca = true;
            Destroy(other.gameObject);
            GameObject.Find("SEManager").SendMessage("Vanila");
            GameObject.Find("Player").SendMessage("Miss");
        }

        //相手オブジェクトがチョココロネだった場合
        if (other.gameObject.tag == "Korone")
        {
            //Debug.Log("チョココロネ");
            haveKorone += 1;
            //Debug.Log(haveKorone);
            Destroy(other.gameObject);
            GameObject.Find("SEManager").SendMessage("Korone");
        }

        //相手オブジェクトがリオレイアだった場合
        if (other.gameObject.tag == "Reia")
        {
            //Debug.Log("チョココロネ");
            //Debug.Log(haveKorone);
            Destroy(other.gameObject);
            GameObject.Find("SEManager").SendMessage("Reia");
        }

        //タグ"End"のオブジェクトだった場合
        if (other.gameObject.tag == "End")
        {
            //
            PlayerPrefs.SetInt("Score", haveKorone);

            //チョコモナカジャンボを取得した場合
            if (getMonaca == true)
            {
                //Debug.Log(getMonaca);     
                SceneManager.LoadScene("ResultA");
            }

            //チョコモナカジャンボを取得していない場合
            else
            {
                //Debug.Log(getMonaca);         
                SceneManager.LoadScene("ResultB");
            }
        }
    }
}
