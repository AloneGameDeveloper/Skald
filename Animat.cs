using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animat : MonoBehaviour
{



    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {



        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {

            anim.SetInteger("Walk", 1);

        }
        else
        {
            anim.SetInteger("Walk", 0);
        }

       
        }





    }

