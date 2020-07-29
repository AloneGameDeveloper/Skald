using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject WolfHelp;


    public Transform PlayerParent;

    public CharacterController controller;

    public static float speed;
    public float gravity = -9.82f;

    public static bool activebut = false;
    public static bool InsadeControl = false;
    public static bool TakeHay = false;
    public static bool TakeHayControl = false;
    public static bool PlaceHayControl = false;
    public static bool PlaceHay = false;
    public static bool HayPlaceControl = false;
    public static bool HayPlacet = false;
    public static bool TakeLog = false;
    public static bool TakeLogControl = false;
    public static bool PlaceLogControl = false;
    public static bool LogPlace = false;
    public static bool LogBakeControl = false;
    public static bool LogBake = false;
    public static bool ControlSleep = false;
    public static bool Sleep = false;
    public static bool WakeUp = false;
    public static bool HandCandleControl = false;
    public static bool HandCandle = false;
    public static bool HandCandlePlaceControl = false;
    public static bool CandlePlace = false;
    public static bool inWater = false;
    public static bool WolfHelpActive = false;

    public static float TimeSleep;
    public static float TimeWake;





    Vector3 velocity;

    void Start()
    {
        speed = 3f;
        TakeHay = false;
    }

    void Update()
    {
    
        activebut = false;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {
            activebut = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            WolfHelp.SetActive(true);
            WolfHelpActive = true;
            WolfHelp.transform.SetParent(null);
        }

        if(WolfHelpActive == false)
        {
            WolfHelp.SetActive(false);
            WolfHelp.transform.SetParent(PlayerParent);
        }

        if (LightingManager.Night == true) {
            if (ControlSleep == true)
            {
                if (activebut == true)
                {
                LightingManager.TimeOfDay = 0f;
                    TimeWake = 3f;
                    TimeSleep = 3f;
                    Sleep = true;

                }
            }
       }

        if(Sleep == true)
        {
            TimeSleep -= Time.deltaTime;
        }
        if(WakeUp == true)
        {
            TimeWake -= Time.deltaTime;
        }
        if (TimeSleep <= 0)
        {
            Sleep = false;
            WakeUp = true;
        }
        if (TimeWake <= 0)
        {
            WakeUp = false;
        }

        if (HandCandle == false)
        {
            if (activebut == true)
        {
            if(TakeHayControl == true)
            {
                TakeHay = true;
                PlaceHay = false;
            }
        }
            if (TakeHay == true)
            {
                if (activebut == true)
                {
                    if (PlaceHayControl == true)
                    {
                        PlaceHay = true;
                        TakeHay = false;
                    }
                }
            }

            if (TakeHay == true)
            {
                if (activebut == true)
                {
                    if (HayPlaceControl == true)
                    {
                        if (HeyTake.i <= 3) {
                            HeyTake.i++;
                            HayplateIn.placened = 1;
                        }
                        HayPlacet = true;
                        PlaceHay = true;
                    }
                }
            }
        }

        if(TakeLogControl == true)
        {
            if(activebut == true)
            {
                TakeLog = true;
                LogPlace = false;
                LogBake = false;

            }
        }

        if(HayPlacet == true)
        {
            TakeHay = false;
        }

        if (TakeLog == true)
        {
            if (PlaceLogControl == true)
            {
                if (activebut == true)
                {
                    LogPlace = true;
                    TakeLog = false;
                }
            }
        }

        if(TakeLog == true)
        {
            if(LogBakeControl == true)
            {
                if (activebut == true)
                {
                    CoalScript.fireTime += 300f;
                    CoalScript.fire = true;
                    LogBake = true;
                    if(LogTake.i <= 3)
                    {
                        LogTake.i++;
                    }
                }
            }
        }

        if(LogBake == true)
        {
            TakeLog = false;
        }

        if (TakeHay == false)
        {
            if (HandCandleControl == true)
            {
                if (activebut == true)
                {
                    HandCandle = true;
                    CandlePlace = false;
                }
            }
            if (HandCandlePlaceControl == true)
            {
                if (activebut == true)
                {
                    HandCandle = false;
                    CandlePlace = true;
                }
            }
        }
    }



    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Inside")
        {
            InsadeControl = true;
        }
        if (other.tag == "Hay")
        {
            TakeHayControl = true;
        }

        if (other.tag == "Outside")
        {
            InsadeControl = false;
        }
        if(other.tag == "Water")
        {
            speed = 1.5f;
            inWater = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Water")
        {
            speed = 3f;
            inWater = false;
        }
    }
}
