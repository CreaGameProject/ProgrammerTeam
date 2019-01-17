using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    void Update()
    {
        Animator anim = GetComponent<Animator>();

        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("Attack", true);
        }

        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);

        if (state.IsName("Locomotion.Attack"))
        {
            anim.SetBool("Attack", false);
        }

        //Animator kick = GetComponent<Animator>();

        //if (Input.GetKeyDown("z"))
        //{
        //    kick.SetBool("Spinkick", true);
        //}

        //AnimatorStateInfo stay = anim.GetCurrentAnimatorStateInfo(0);

        //if (stay.IsName("Locomotion.Spikick"))
        //{
        //    kick.SetBool("Spinkick", false);
        //}

    }

    public void Hit()        // ヒット時のアニメーションイベント（今のところからっぽ。ないとエラーが出る）
    {
    }

}
