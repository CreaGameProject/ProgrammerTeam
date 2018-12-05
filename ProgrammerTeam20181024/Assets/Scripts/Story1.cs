using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class Story1 : MonoBehaviour
{
    [SerializeField] Text textBox;
    [SerializeField] SpriteRenderer body, face;

    [SerializeField] SpriteAtlas atlas;

    IEnumerator Start()
    {
        textBox.text = "衝撃のファーストブリット";
        body.sprite = atlas.GetSprite("kohaku_base");
        //face.sprite = atlas.GetSprite("kohaku_base");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        face.sprite = atlas.GetSprite("kohaku_1");
        textBox.text = "撃滅のセカンドブリット";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        //face.sprite = atlas.GetSprite("kohaku_base");
        face.sprite = null;
        textBox.text = "抹殺のラストブリット";
    }
}
