using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepWalk : MonoBehaviour
{


   

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (SheepWalkF.walkanim == true)
        {
            anim.SetInteger("walk", 1);
        }
        if(SheepWalkF.walkanim == false)
        {
            anim.SetInteger("walk", 0);
        }
    }
}
