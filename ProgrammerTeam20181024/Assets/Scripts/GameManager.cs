using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Transform player;
    private float diffY;
    private float diffX;
    private float meet;

    void Start()
    {

    }

    void Update()
    {
        if ( Input.GetMouseButtonDown( 0 ) )
        {
            Swing();
        }
    }

    private void Swing()
    {
        diffY = ball.position.y - player.position.y;

        if(Mathf.Abs(diffY) > 1 )
        {
            return;
        }

        diffX = ball.position.x - player.position.x;

        if(Mathf.Abs(diffX) > meet )
        {
            return;
        }
    }
}
