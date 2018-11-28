using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkingText : MonoBehaviour {

    Text textEdit;
    
    // Use this for initialization
	void Start ()
    {
        StartCoroutine(TextController());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator TextController()
    {
        textEdit.text = "あっ！";
        Debug.Log(1);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEdit.text = "明後日のPl会議の議長俺や！";
        Debug.Log(2);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEdit.text = "カオスなことになりそう \n 楽しみやなあ～～";
        Debug.Log(3);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        yield break;
    }







}
