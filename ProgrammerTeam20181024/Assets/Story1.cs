using System.Collections;
using UnityEngine;
using UnityEngine.U2D;

public class Story1 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textbox;
    [SerializeField] SpriteRenderer body, face;

    [SerializeField] SpriteAtlas atlas;

    IEnumerator Start()
    {
        textbox.text = "衝撃のファーストブリット";
        body.sprite = atlas.GetSprite("サンプル1");
        //face.sprite = atlas.GetSprite("kohaku_1");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        face.sprite = atlas.GetSprite("サンプル");
        textbox.text = "撃滅のセカンドブリット";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        // face.sprite = atlas.GetSprite("kohaku_3");
        face.sprite = null;
        textbox.text = "抹殺のラストブリット";
    }
}