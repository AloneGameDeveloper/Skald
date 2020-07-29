using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingManager : MonoBehaviour
{
    [Range(0,1)]
    public static float TimeOfDay;
    public float DayDuration = 900f;

    public AnimationCurve SunCurve;
    public AnimationCurve MoonCurve;
    public AnimationCurve SkyboxCurve;


    public ParticleSystem Stars;

    public Material DaySkyBox;
    public Material NightSkyBox;

    public Light Sun;
    public Light Moon;

    public static bool Night;
    public static bool Day;

    private float SunIntensivity;
    private float MoonIntensivity;

    // Start is called before the first frame update
    void Start()
    {
        SunIntensivity = Sun.intensity;
        MoonIntensivity = Moon.intensity;
        TimeOfDay = 0.69f;

    }

    // Update is called once per frame
    void Update()
    {



        if(TimeOfDay <= 0.5f)
        {
            Day = true;
            Night = false;
        }
        if(TimeOfDay >= 0.5f)
        {
            Night = true;
            Day = false;
        }




        TimeOfDay += Time.deltaTime / DayDuration;
        if(TimeOfDay >= 1)
        {
            TimeOfDay -= 1;
        }

        RenderSettings.skybox.Lerp(NightSkyBox, DaySkyBox, SkyboxCurve.Evaluate(TimeOfDay));
        RenderSettings.sun = SkyboxCurve.Evaluate(TimeOfDay) > 0.1f ? Sun : Moon;
        DynamicGI.UpdateEnvironment();

        var mainModule = Stars.main;
        mainModule.startColor = new Color(1, 1, 1, SkyboxCurve.Evaluate(TimeOfDay));

        Sun.transform.localRotation = Quaternion.Euler(TimeOfDay * 360f, 180, 0);
        Moon.transform.localRotation = Quaternion.Euler(TimeOfDay * 360f + 180f, 180, 0);
        Sun.intensity = SunIntensivity * SunCurve.Evaluate(TimeOfDay);
        Moon.intensity = MoonIntensivity * MoonCurve.Evaluate(TimeOfDay);
    }
}
