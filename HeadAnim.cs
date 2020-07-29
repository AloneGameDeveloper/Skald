using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAnim : MonoBehaviour
{



    public static bool animeat;

    Animator anim;

   
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(animeat == true)
        {
            anim.SetInteger("Eat", 1);
        }
        if(animeat == false)
        {
            anim.SetInteger("Eat", 0);
        }
    }
}
