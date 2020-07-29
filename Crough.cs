using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crough : MonoBehaviour
{

    CharacterController playercol;


    float originalHeight;
    public float reduceredHeight;


    void Start()
    {
        playercol = GetComponent<CharacterController>();
        originalHeight = playercol.height;
    }


    void Update()
    {
        if (PlayerMovement.inWater == false)
        {
            if (Input.GetKey(KeyCode.C))
            {
                Crought();
                PlayerMovement.speed = 1.5f;
            }
            else
            {
                GetUp();
                PlayerMovement.speed = 3f;
            }
        }
    }

    void Crought()
    {
        playercol.height = reduceredHeight;
    }
    void GetUp()
    {
        playercol.height = originalHeight;
    }


}
