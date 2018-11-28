using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendingText : MonoBehaviour {

    IEnumerator Start()
    {
        Debug.Log( "衝撃のファーストブリット" );
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        Debug.Log( "撃滅のセカンドブリット" );
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        Debug.Log( "抹殺のラストブリット" );
    }
}
