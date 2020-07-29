using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayplateIn : MonoBehaviour
{


    public GameObject Point1;
    public GameObject Point2;
    public GameObject HayInPlate1;
    public static int placened = 0;
    public static bool SheepEat1 = false;
    public static bool SheepEat2 = false;



    void Start()
    {
        
    }

    void Update()
    {



        if(placened == 1)
        {
            HayInPlate1.SetActive(true);
            SheepEat1 = true;
            SheepEat2 = true;
            Point1.SetActive(true);
            Point2.SetActive(true);
        }

        if(placened == 0)
        {
            Point1.SetActive(false);
            Point2.SetActive(false);
            HayInPlate1.SetActive(false);
           

        }
    }
}
