 /// <summary>
/// 
/// </summary>

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Animator))]  

//Name of class must be name of file as well

public class LocomotionPlayer : MonoBehaviour {

    protected Animator animator;

    private float speed = 0;
    private float direction = 0;
    private Locomotion locomotion = null;
    private bool motion = false;

    IEnumerator Act()
    {
        motion = true;
        yield return new WaitForSeconds(1.4f);
        motion = false;
    }

    // Use this for initialization
    void Start () 
	{
        animator = GetComponent<Animator>();
        locomotion = new Locomotion(animator);
	}
    
	void Update () 
	{
        if (animator && Camera.main&& motion==false)
		{
            
            JoystickToEvents.Do(transform,Camera.main.transform, ref speed, ref direction);
            locomotion.Do(speed * 6, direction * 180);
		}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ê¬ÉuÉ^");
            Debug.Log("FGO");
            StartCoroutine(Act());
        }
	}

    
}
