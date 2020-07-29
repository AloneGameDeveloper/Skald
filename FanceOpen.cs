using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanceOpen : MonoBehaviour
{

    bool Open;



    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }


    void Update() {

        if (Open == true)
        {
            if (PlayerMovement.activebut == true)
            {
                anim.SetInteger("Open", 1);
            }
        }
        if(Open == false)
        {
            if (PlayerMovement.activebut == true)
            {
                anim.SetInteger("Open", 2);
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Open = true;

        }
        if (other.tag == "FanceDoorOpen")
        {
            Open = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Open = true;
           
        }
    }
}
