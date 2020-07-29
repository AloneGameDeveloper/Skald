using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCandle : MonoBehaviour
{

    public GameObject TakePoint;
    public Transform PlayerPointParent;
    public Transform PointCandleParent;
    public GameObject Candle;
    public GameObject PlacePoint;

    void Start()
    {
        
    }

    void Update()
    {
        if(PlayerMovement.HandCandle == true)
        {
            Candle.transform.position = Vector3.Lerp(transform.position, TakePoint.transform.position, 1f);
            Candle.transform.SetParent(PlayerPointParent);
            Candle.transform.localEulerAngles = new Vector3(0, 60, 0);
        }
        if(PlayerMovement.CandlePlace == true)
        {
            Candle.transform.position = Vector3.Lerp(transform.position, PlacePoint.transform.position, 1f);
            Candle.transform.SetParent(PointCandleParent);
            Candle.transform.localEulerAngles = new Vector3(0, 43.94f, 0);
            Candle.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
