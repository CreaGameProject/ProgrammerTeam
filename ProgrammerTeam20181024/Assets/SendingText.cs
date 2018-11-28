using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendingText : MonoBehaviour {

    [SerializeField] private Text text;

    IEnumerator Start()
    {
        text.text = "衝撃のファーストブリット";
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        text.text = "撃滅のセカンドブリット";
        yield return new WaitUntil( () => Input.GetMouseButtonDown( 0 ) );
        yield return null;

        text.text = "抹殺のラストブリット";
    }
}
