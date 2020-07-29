using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepWalkF1 : MonoBehaviour
{
    public GameObject sheeps;
    public GameObject EatPoint1;

    Rigidbody rb;
    float speed = 0.007f;
    int rotat;
    float time = 5;
    int a;
    public static bool walkanim = false;
    public static float timeEat = 5;
    bool EatTime1 = false;
    public static bool StartAnimation = false;


    Animator anim;

    void walk()
    {

        rb.velocity -= transform.position * speed;

    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        timeEat = 5;
    }



    void Update()
    {



        if (walkanim == true)
        {

            if (rotat == 1)
            {
                // anim.SetInteger("Rotate", 1);
                transform.localEulerAngles = new Vector3(0, 133, 0);
                transform.Rotate(0f, 1f, 0f);
            }
            if (rotat == 2)
            {
                // anim.SetInteger("Rotate", 2);
                transform.localEulerAngles = new Vector3(0, 180, 0);
            }
            if (rotat == 3)
            {
                // anim.SetInteger("Rotate", 3);
                transform.localEulerAngles = new Vector3(0, 210, 0);
            }
            if (rotat == 4)
            {
                //anim.SetInteger("Rotate", 4);
                transform.localEulerAngles = new Vector3(0, 56, 0);
            }
            if (rotat == 5)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            if (rotat == 6)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 295, 0);
            }
            if (rotat == 7)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 310, 0);
            }
            if (rotat == 8)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 360, 0);
            }
            if (rotat == 9)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 40, 0);
            }
            if (rotat == 10)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 215, 0);
            }
            if (rotat == 11)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 280, 0);
            }
            if (rotat == 12)
            {
                //anim.SetInteger("Rotate", 5);
                transform.localEulerAngles = new Vector3(0, 320, 0);
            }
        }


        if (HayplateIn.SheepEat2 == true)
        {
            transform.position = Vector3.Lerp(transform.position, EatPoint1.transform.position, speed);
            transform.localEulerAngles = new Vector3(0, 320, 0);
            walkanim = false;

        }




        time -= Time.deltaTime;

        if (time <= 0)
        {
            a = Random.Range(1, 5);
            time = 5;
        }

        if (a == 4)
        {
            walkanim = true;

        }

        if (walkanim == true)
        {
            transform.position = Vector3.Lerp(transform.position, sheeps.transform.position, speed);

        }
        if (EatTime1 == true)
        {
            HeadAnim1.animeat1 = true;
            walkanim = false;
            timeEat -= Time.deltaTime;
            speed = 0f;
            if (timeEat <= 0)
            {
                EatTime1 = false;
                transform.localEulerAngles = new Vector3(0, 40, 0);
                HayplateIn.SheepEat2 = false;
            }
        }
        if (EatTime1 == false)
        {
            speed = 0.007f;
            HeadAnim1.animeat1 = false;
            timeEat = 5;

        }




    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fance")
        {
            walkanim = false;
            //rotat = Random.Range(1, 3);
            rotat = 1;
        }
        if (other.tag == "Fance2")
        {
            walkanim = false;
            rotat = Random.Range(4, 6);
        }
        if (other.tag == "Fance3")
        {
            walkanim = false;
            rotat = Random.Range(7, 9);
        }
        if (other.tag == "Fance4")
        {
            walkanim = false;
            rotat = Random.Range(10, 12);
        }
        if (other.tag == "Eat1")
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
            HayplateIn.placened = 0;
            HayplateIn.SheepEat2 = false;
            walkanim = false;
            EatTime1 = true;

        }
        if(other.tag == "Sheep")
        {
            if (HayplateIn.SheepEat2 == false)
            {
                rotat = Random.Range(1, 12);
            }
        }
    }


}
