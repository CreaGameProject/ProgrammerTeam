using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject target;//プレイヤーオブジェクト指定

    NavMeshAgent navMeshAgent;//インスタンス格納用変数

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(target.transform.position);//Vecter3型で移動先の座標を指定
    }
}
