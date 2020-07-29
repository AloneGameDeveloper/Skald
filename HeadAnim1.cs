using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAnim1 : MonoBehaviour
{
    public static bool animeat1;

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (animeat1 == true)
        {
            anim.SetInteger("EatSheep", 1);
        }

        if (animeat1 == false)
        {
            anim.SetInteger("EatSheep", 0);
        }
    }
}
