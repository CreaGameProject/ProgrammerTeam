using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextMassage : MonoBehaviour {

    [SerializeField]
    Text text;

    [SerializeField]
    Button yes;

    [SerializeField]
    Button no;

    bool choice;
    int choiceNumber = 0;

    // Use this for initialization
	void Start ()
    {
        yes.enabled = false;
        no.enabled = false;
        StartCoroutine(TextManager());
        choice = false;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(choice);
	}

    private IEnumerator TextManager()
    {
        text.text = "ねえ？";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        yield return new WaitForSeconds(0.1f);

        text.text = "あなたホームラン打てるの？";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        yield return new WaitForSeconds(0.1f);

        yes.enabled = true;
        no.enabled = true;

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
            //yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
            text.text = "そう，じゃあ頑張ってね～";
            yield return new WaitForSeconds(2.0f);
            SceneManager.LoadScene("SampleScene");

            yield break;
        //}

        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        //text.text = "死ね";
        //yield return new WaitForSeconds(2.0f);
        //SceneManager.LoadScene("GameOver");
        //yield break;

        // }
        //yield return new WaitUntil(() => choice == true);

        //Debug.Log(choiceNumber);
        //TalkingChoiceYes();
        //TalkingChoiceNo();
        //switch (choiceNumber)
        //{

        //    case 1:
        //        text.text = "そう，じゃあ頑張ってね～";
        //        yield return new WaitForSeconds(2.0f);
        //        SceneManager.LoadScene("SampleScene");
        //        break;

        //    case 2:
        //        text.text = "死ね";
        //        yield return new WaitForSeconds(2.0f);
        //        SceneManager.LoadScene("GameOver");
        //        break;
        //}


    }

    public void TalkingChoiceYes()
    {
        if (Input.GetMouseButtonDown(0))
        {
            choice = true;
            choiceNumber = 1;
        }
    }

    public void TalkingChoiceNo()
    {
        if (Input.GetMouseButtonDown(0))
        {
            choice = true;
            choiceNumber = 2;
        }
    }

}
