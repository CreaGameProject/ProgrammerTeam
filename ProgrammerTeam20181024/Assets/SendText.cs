using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendText : MonoBehaviour {

    [SerializeField] UnityEngine.UI.Text textbox;

    IEnumerator Start()
    {
        textbox.text = "ねえ、…ずっと前の話、覚えている?";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "…。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "…消されるときは一緒よ。";

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "…なんて。";

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "裏切らないでね。";

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "…私を";

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textbox.text = "嫉妬深いんだから。";

    }
}
