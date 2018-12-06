using System.Collections;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textbox;
    [SerializeField] Image body, face;

    [SerializeField] SpriteAtlas atlas;

    IEnumerator Start()
    {
        textbox.text = "衝撃のファーストブリット";
        face.sprite = atlas.GetSprite("sample_1");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        face.sprite = atlas.GetSprite("sample_3");
        textbox.text = "撃滅のセカンドブリット";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        face.sprite = atlas.GetSprite("sample_4");
        textbox.text = "抹殺のラストブリット";
    }
}
