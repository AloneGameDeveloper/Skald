using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPlayer : MonoBehaviour
{

    public float distance = 1f;

    public GameObject CanvasTake;
    public GameObject CanvasPlace;
    public GameObject CanvasTakeLog;
    public GameObject CanvasPlaceLog;
    public GameObject CanvasTakeCandle;
    public GameObject CanvasPlaceCandle;


    void Start()
    {
        CanvasTake.SetActive(false);
        CanvasPlace.SetActive(false);  
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }


    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hay")
        {
            PlayerMovement.TakeHayControl = true;
            CanvasTake.SetActive(true);
        }

        if (other.tag == "HayPlace")
        {
            PlayerMovement.TakeHayControl = true;
            CanvasPlace.SetActive(true);
        }

        if(other.tag == "HayPlate")
        {
            PlayerMovement.HayPlaceControl = true;
        }

        if(other.tag == "Logs")
        {
            PlayerMovement.TakeLogControl = true;
            CanvasTakeLog.SetActive(true);
        }
        if(other.tag == "LogPlace")
        {
            PlayerMovement.PlaceLogControl = true;
            CanvasPlaceLog.SetActive(true);
        }
        if(other.tag == "Bake")
        {
            PlayerMovement.LogBakeControl = true;
        }

        if(other.tag == "Door")
        {
            DoorOpenClose.OpenDoorControl = true;
        }
        if(other.tag == "BedSleep")
        {
            PlayerMovement.ControlSleep = true;
        }
        if(other.tag == "TakeHandCandle")
        {
            PlayerMovement.HandCandleControl = true;
        }
        if(other.tag == "PlaceHandCandle")
        {
            PlayerMovement.HandCandlePlaceControl = true;
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hay")
        {
            PlayerMovement.TakeHayControl = true;
        }
        if (other.tag == "HayPlace")
        {
            PlayerMovement.PlaceHayControl = true;
        }
        if (other.tag == "HayPlate")
        {
            PlayerMovement.HayPlaceControl = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Hay")
        {
                PlayerMovement.TakeHayControl = false;
            CanvasTake.SetActive(false);
        }
        if (other.tag == "HayPlace")
        {
            PlayerMovement.PlaceHayControl = false;
            CanvasPlace.SetActive(false);
        }

        if (other.tag == "HayPlate")
        {
            PlayerMovement.HayPlaceControl = false;
            PlayerMovement.HayPlacet = false;
        }
        if (other.tag == "Logs")
        {
            PlayerMovement.TakeLogControl = false;
            CanvasTakeLog.SetActive(false);
        }
        if (other.tag == "LogPlace")
        {
            PlayerMovement.PlaceLogControl = false;
            CanvasPlaceLog.SetActive(false);
        }
        if (other.tag == "Bake")
        {
            PlayerMovement.LogBakeControl = false;
        }
        if (other.tag == "Door")
        {
            DoorOpenClose.OpenDoorControl = false;
        }
        if (other.tag == "BedSleep")
        {
            PlayerMovement.ControlSleep = false;
        }
        if (other.tag == "TakeHandCandle")
        {
            PlayerMovement.HandCandleControl = false;
        }
        if (other.tag == "PlaceHandCandle")
        {
            PlayerMovement.HandCandlePlaceControl = false;
        }
    }
}
