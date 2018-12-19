using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour
{
    [SerializeField] List<string> messages;
    [SerializeField] Text text;
    private List<string>.Enumerator enumerator;
    [SerializeField] GameObject button;

    void Start()
    {
        enumerator = messages.GetEnumerator();
        if(enumerator.MoveNext())
        {
            text.text = enumerator.Current;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && enumerator.MoveNext())
        {
            text.text = enumerator.Current;
        }

        if (text.text == messages[3])
        {
            button.SetActive(true);
        }
    }
}
