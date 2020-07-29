using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public GameObject AlphaObj;
    public Image AlphaImage;
    public int Alpha;


    void Start()
    {
        
    }

    void Update()
    {


       

//        Debug.Log(AlphaImage.color.a);

        if(AlphaImage.color.a <= -0.1f)
        {
            PlayerMovement.WakeUp = false;
        }
        if(AlphaImage.color.a >= 1f)
        {
            PlayerMovement.Sleep = false;
            PlayerMovement.WakeUp = true;
        }

        if (PlayerMovement.Sleep == true)
        {
            AlphaImage = AlphaObj.GetComponent<Image>();
            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a + 0.5f * Time.deltaTime);

        }
        if(PlayerMovement.WakeUp == true)
        {
            AlphaImage = AlphaObj.GetComponent<Image>();
            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a - 0.5f * Time.deltaTime);

        }
    }
}
