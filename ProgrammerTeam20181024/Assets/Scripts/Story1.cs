using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{
    [SerializeField] Text textBox;

    IEnumerator Start()
    {
        textBox.text = "衝撃のファーストブリット";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textBox.text = "撃滅のセカンドブリット";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textBox.text = "抹殺のラストブリット";
    }
}
