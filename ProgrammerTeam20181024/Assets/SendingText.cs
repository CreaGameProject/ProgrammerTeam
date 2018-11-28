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

        if ( enumerator.MoveNext() )
            text.text = enumerator.Current;
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        if ( enumerator.MoveNext() )
            text.text = enumerator.Current;
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        if ( enumerator.MoveNext() )
            text.text = enumerator.Current;
    }
}
