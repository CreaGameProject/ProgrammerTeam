using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform tfCache;
    [SerializeField] private Transform centerPosition;
    private Vector3 centerPos;
    private Vector3 mousePos;

    [SerializeField] private float limit;

    void Start()
    {
        tfCache = transform;
        centerPos = centerPosition.localPosition;
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        tfCache.position = Vector3.MoveTowards( tfCache.position, mousePos, 0.02f );
        //if(Mathf.Abs( centerPosition.position.x) < limit &&)
    }
}
