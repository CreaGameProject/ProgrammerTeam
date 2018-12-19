using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{

    private Transform tfCache;
    [SerializeField] private float amount;
    private Vector3 scale;
    private float defaultScale;
    private float changedScale;

    void Start()
    {
        tfCache = transform;
        scale = tfCache.localScale;
        defaultScale = tfCache.localScale.x;
    }

    void Update()
    {
        changedScale = defaultScale + Mathf.Abs( tfCache.localPosition.y ) * amount;
        scale.Set( changedScale, changedScale, 1 );
        tfCache.localScale = scale;
    }
}
