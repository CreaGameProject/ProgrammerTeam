using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Send_text : MonoBehaviour
{

    [SerializeField] UnityEngine.UI.Text textbox;
    [SerializeField] Image body, face;

    [SerializeField] SpriteAtlas atlas;
    IEnumerator Start()
    {
        textbox.text ="おはよう";
        body.sprite = atlas.GetSprite("maki_body");
        face.sprite = atlas.GetSprite("maki_1");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        face.sprite = atlas.GetSprite("maki_2");
        textbox.text ="お腹すいた";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        face.sprite = atlas.GetSprite("maki_3");
        textbox.text = "おやすみ";
    }
}