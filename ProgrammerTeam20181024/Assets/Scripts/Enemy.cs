using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent meshAgent;
    void Start()
    {
        player = GameObject.Find("Player");
        meshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        player = GameObject.Find("Player");
        meshAgent.SetDestination(player.transform.position);
    }

}
