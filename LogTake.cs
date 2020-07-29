using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTake : MonoBehaviour
{

    public GameObject TakePoint;
    public Transform PlayerPointParent;
    public Transform PointLogParent;
    public Transform PlatePointLog;
    public GameObject PlatePlaceLog;
    public GameObject[] Logs;
    public GameObject[] PlacePoint;
    public static int i = 0;


    void Start()
    {
        
    }


    void Update()
    {

        if(PlayerMovement.TakeLog == true)
        {
            Logs[i].transform.position = Vector3.Lerp(transform.position, TakePoint.transform.position, 1f);
            Logs[i].transform.SetParent(PlayerPointParent);
            Logs[i].transform.localEulerAngles = new Vector3(0, 60, 0);
        }

        if(PlayerMovement.LogPlace == true)
        {
            Logs[i].transform.position = Vector3.Lerp(transform.position, PlacePoint[i].transform.position, 1f);
            Logs[i].transform.SetParent(PointLogParent);
            Logs[i].transform.localEulerAngles = new Vector3(0, 43.94f, 0);
            Logs[i].transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (PlayerMovement.LogBake == true)
        {
            Logs[i - 1].SetActive(false);



        }

    }
}
