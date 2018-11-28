using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Send_text : MonoBehaviour
{

    [SerializeField] UnityEngine.UI.Text textbox;
    IEnumerator Start()
    {
        textbox.text ="おはよう";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text ="お腹すいた";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "おやすみ";
    }
}