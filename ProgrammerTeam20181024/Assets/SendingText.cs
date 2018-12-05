using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class SendingText : MonoBehaviour
{

    [SerializeField] private Text text;
    [SerializeField] private List<string> msg;
    private List<string>.Enumerator enumerator;

    [SerializeField] Image body, face;

    [SerializeField] SpriteAtlas atlas;


    IEnumerator Start()
    {
        //body.sprite = atlas.GetSprite( "base" );

        enumerator = msg.GetEnumerator();

        yield return StartCoroutine( "OnClick" );
        yield return null;

        yield return StartCoroutine( "OnClick" );
        yield return null;

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

        face.sprite = atlas.GetSprite( "sample_4" );
        foreach ( char item in enumerator.Current )
        {
            face.gameObject.SetActive( true );
            text.text += item;
            yield return new WaitForSeconds( 0.075f );
            face.gameObject.SetActive( false );
            yield return new WaitForSeconds( 0.025f );
        }

        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
    }
}
