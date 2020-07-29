using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHelpScript : MonoBehaviour
{
    public Transform HomePoint;
    public GameObject PlayerPoint;



    void Start()
    {
        
    }


    void Update()
    {
        if (PlayerMovement.WolfHelpActive == true)
        {
            transform.position = Vector3.Lerp(transform.position, HomePoint.transform.position, 0.007f);

        }

        Vector3 direction = (HomePoint.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x , 0, direction.z));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * 1f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Home")
        {
            transform.position = Vector3.Lerp(transform.position, PlayerPoint.transform.position, 1f);
            PlayerMovement.WolfHelpActive = false;
        }
    }
}
