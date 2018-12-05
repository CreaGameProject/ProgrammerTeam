using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class SendingText : MonoBehaviour {

    [SerializeField] private Text text;
    [Header("int"), SerializeField] int a;
    [SerializeField] private List<string> msg;
    private List<string>.Enumerator enumerator;
    [SerializeField]SpriteRenderer body, face;

    [SerializeField] SpriteAtlas atlas;
    [HideInInspector] public string b;

    IEnumerator Start()
    {
        enumerator = msg.GetEnumerator();

        body.sprite = atlas.GetSprite("Sample_body");
        face.sprite = atlas.GetSprite("Sample_face1");
        yield return StartCoroutine( "OnClick" );
        yield return null;

        face.sprite = atlas.GetSprite("Sample_face2");
        yield return StartCoroutine( "OnClick" );
        yield return null;

        face.sprite = atlas.GetSprite("Sample_face3");
        yield return StartCoroutine( "OnClick" );
        yield return null;
    }

    public IEnumerator OnClick()
    {
        if ( !enumerator.MoveNext() )
        {
            yield break;
        }

        text.text = "";

        foreach ( char item in enumerator.Current )
        {
            text.text += item;
            yield return new WaitForSeconds( 0.1f );
        }

        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
    }
}
