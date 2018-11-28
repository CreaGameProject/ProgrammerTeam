using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendingText : MonoBehaviour {

    [SerializeField] private Text text;
    [SerializeField] List<string> msg;
    private List<string>.Enumerator enumerator;

    IEnumerator Start()
    {
        enumerator = msg.GetEnumerator();

        StartCoroutine( "OnClick" );
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        StartCoroutine( "OnClick" );
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        StartCoroutine( "OnClick" );
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
    }
}
