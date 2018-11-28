using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanasi : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textbox;

    IEnumerator Start()
    {
        textbox.text = ("飯");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = ("食べる");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = ("うまい");
    
    }
}
