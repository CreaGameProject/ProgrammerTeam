using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendingText : MonoBehaviour {

    [SerializeField] private Text text;
    [Header("int"), SerializeField] int a;
    [SerializeField] private List<string> msg;
    private List<string>.Enumerator enumerator;
    [HideInInspector] public string b;

    IEnumerator Start()
    {
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

        foreach ( char item in enumerator.Current )
        {
            text.text += item;
            yield return new WaitForSeconds( 0.1f );
        }

        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
    }
}
