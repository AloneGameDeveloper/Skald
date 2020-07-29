using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    public GameObject HowlPoint;
    public GameObject DenPoint;

    public GameObject WolfAllBody;

    private float speed = 0.1f;
    public static bool Howl = false;
    public static bool HowlAction = false;
    public static bool Den = false;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;
    private float TimeHowl = 7f;

    void Update()
    {
        if(LightingManager.TimeOfDay >= 0.7f && LightingManager.TimeOfDay <= 0.72f)
        {
            Howl = true;
        }
        else
        {
            Howl = false;
        }
        if (Howl == true)
        {
            WolfAllBody.SetActive(true);
            transform.position = Vector3.Lerp(transform.position, HowlPoint.transform.position, speed);
            transform.localEulerAngles = new Vector3(0, 0, 30f);
        }
        if(Howl == false)
        {
            transform.position = Vector3.Lerp(transform.position, DenPoint.transform.position, speed);
            transform.localEulerAngles = new Vector3(0, 180, 0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Howl")
        {
            audioSource.PlayOneShot(clip, volume);
        }
        if(other.tag == "Den")
        {
            WolfAllBody.SetActive(false);
        }
        if(other.tag == "Player")
        {
            Howl = false;
        }
    }
    
}
