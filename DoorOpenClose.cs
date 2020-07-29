using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{

    bool Open;
    public static bool OpenDoorControl = false;
    bool OpenOut = false;
    bool OpenIn = false;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("Action", 0);
    }

    void Update()
    {



        if (OpenDoorControl == true)
        {
            if (Open == true)
            {
                if (PlayerMovement.InsadeControl == false)
                {

                    if (PlayerMovement.activebut == true)
                    {
                        if (OpenOut == false)
                        {
                            anim.SetInteger("Action", 1);
                        }
                        if (OpenOut == true)
                        {
                            anim.SetInteger("Action", 4);
                        }
                        if (OpenIn == true)
                        {
                            anim.SetInteger("Action", 3);
                        }
                    }
                }

            }

            if (Open == true)
            {
                if (PlayerMovement.InsadeControl == true)
                {

                    if (PlayerMovement.activebut == true)
                    {

                        if (OpenIn == false)
                        {
                            anim.SetInteger("Action", 2);
                        }
                        if (OpenIn == true)
                        {
                            anim.SetInteger("Action", 3);
                        }
                        if (OpenOut == true)
                        {
                            anim.SetInteger("Action", 4);
                        }
                    }
                }

            }
        }



    }

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Open = true;
        }
        if(other.tag == "OpenOutside")
        {
            OpenOut = true;
        }
        if(other.tag == "DoorClosed")
        {
            OpenOut = false;
            OpenIn = false;
        }
        if(other.tag == "OpenInside")
        {
            OpenIn = true;
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Open = true;
        }
        if (other.tag == "OpenOutside")
        {
            OpenOut = true;
        }
    }
}
