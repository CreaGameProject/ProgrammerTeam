using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour
{
    [SerializeField] List<string> messages;
    [SerializeField] Text text;
    private List<string>.Enumerator enumerator;
    //private string firstText;

    void Start()
    {
        enumerator = messages.GetEnumerator();
        text.text = messages[0];
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && enumerator.MoveNext())
        {
            text.text = enumerator.Current;
        }
    }
}
