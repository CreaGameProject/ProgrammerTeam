using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    void Start()
    {
        //Resourceフォルダ内の全カードオブジェクトにBoxColliderを手作業で追加するのは
        //しんどすぎたので、生成された瞬間に各自で追加するように変更
        gameObject.AddComponent<BoxCollider>();
        GetComponent<BoxCollider>().isTrigger = true;
        StartCoroutine(WaitAndDestroy());
    }

    void Update()
    {
        
    }

    //10秒たったら自動的に消えるように設定
    private IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    //ただの当たり判定
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
