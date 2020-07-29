using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeyTake : MonoBehaviour
{

    public GameObject TakePoint;
    public Transform PlayerPointParent;
    public Transform PointWoodParent;
    public Transform PlatePointHay;
    public GameObject PlatePlaceHay;
    public GameObject[] hays;
    public GameObject[] PlacePoint;
    public static int i = 0;
   



    void Start()
    {
        i = 0;

    }

    void Update()
    {




            if (PlayerMovement.TakeHay == true)
            {
                hays[i].transform.position = Vector3.Lerp(transform.position, TakePoint.transform.position, 1f);
                hays[i].transform.SetParent(PlayerPointParent);
                hays[i].transform.localEulerAngles = new Vector3(0, 90, 0);


            }
            if (PlayerMovement.PlaceHay == true)
            {
                hays[i].transform.position = Vector3.Lerp(transform.position, PlacePoint[i].transform.position, 1f);
                hays[i].transform.SetParent(PointWoodParent);
                hays[i].transform.localEulerAngles = new Vector3(0, 0, 0);
                hays[i].transform.localScale = new Vector3(1.338117f, 0.79414f, 1.195811f);
                

        }
            if(PlayerMovement.HayPlacet == true)
        {
            hays[i-1].SetActive(false);
                    }

         

    }




}
