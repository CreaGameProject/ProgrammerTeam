using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [HideInInspector] public string cardNum;//カードの名前

    


    void Start()
    {
        gameObject.AddComponent<BoxCollider>();
        GetComponent<BoxCollider>().isTrigger = true;
        StartCoroutine(WaitAndDestroy());
    }

    void Update()
    {
        
    }

    public void Turn()
    {
        //StartCoroutine(TurnCor());
    }

    private IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


    //public IEnumerator TurnCor()
    //{

    //}
}
