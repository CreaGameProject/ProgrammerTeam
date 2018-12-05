using System.Collections;
using UnityEngine;

public class Story1 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textbox;

    IEnumerator Start()
    {
        textbox.text = "衝撃のファーストブリット";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "撃滅のセカンドブリット";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "抹殺のラストブリット";
    }
}
