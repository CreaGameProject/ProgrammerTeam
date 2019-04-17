using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPos = transform.position;

        float moveLength = speed * Time.smoothDeltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            curPos.x -= moveLength;
        }
        if (Input.GetKey(KeyCode.D))
        {
            curPos.x += moveLength;
        }
        if (Input.GetKey(KeyCode.W))
        {
            curPos.z += moveLength;
        }
        if (Input.GetKey(KeyCode.S))
        {
            curPos.z -= moveLength;
        }
        navMeshAgent.SetDestination(curPos);
    }
}
