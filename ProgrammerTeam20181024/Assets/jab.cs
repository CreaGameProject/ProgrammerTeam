using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jab : MonoBehaviour {


    void Update()
    {
        Animator anim = GetComponent<Animator>();

        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("Attack", true);
        }

        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);

        if (state.IsName("Locomotion.Jab"))
        {
            anim.SetBool("Attack", false);
        }
    }
}
