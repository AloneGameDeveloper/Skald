using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalScript : MonoBehaviour
{

    public GameObject Coal1;
    public GameObject Coal2;
    public GameObject Light1;
    public GameObject Light2;
    public static bool fire = false;
    public static float fireTime = 0f;

    void Start()
    {
        Light1.SetActive(false);
        Light2.SetActive(false); 
        Coal2.SetActive(false);
        Coal2.SetActive(true);
    }


    void Update()
    {
        if(fire == true)
        {
            Coal1.SetActive(true);
            Coal2.SetActive(false);
            Light1.SetActive(true);
            Light2.SetActive(true);
            fireTime -= Time.deltaTime;
        }

        if(fireTime <= 0)
        {
            fire = false;
            Coal1.SetActive(false);
            Coal2.SetActive(true);
            Light1.SetActive(false);
            Light2.SetActive(false);
        }
    }
}
