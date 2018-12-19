using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class TalkingText : MonoBehaviour {

   
    public Text textEdit;

    [SerializeField]
    SpriteRenderer body, face;

    [SerializeField]
    SpriteAtlas atlas;
    
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
        textEdit.text = "はあ～～～";
        body.sprite = atlas.GetSprite("body");
        face.sprite = atlas.GetSprite("face");
        Debug.Log(1);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEdit.text = "今日は珍しく詰まらねえ日だったなあ";
        face.sprite = atlas.GetSprite("face");
        Debug.Log(2);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEdit.text = "明日が楽しみやわあ～～";
        Debug.Log(3);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEdit.text = "ところで飯はまだか";
        face.sprite = atlas.GetSprite("face");
        Debug.Log(4);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        yield break;
    }







}
