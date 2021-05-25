using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeroGreco : MonoBehaviour
{
    // Change spot angle randomly between 'minAngle' and 'maxAngle'
    // each 'interval' seconds.

    float interval = 1/60f;
    float timeLeft;
    public static bool StartG;

    Light lt;


    void Start()
    {
        lt = GetComponent<Light>();
        lt.type = LightType.Spot;

        timeLeft = interval;
    }

    void Update()
    {
        if (!StartG)
        {
            if (Input.anyKeyDown)
            {
                StartG = true;
            }
        }else
        {
        lt.enabled=true;
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0.0 && lt.spotAngle<100)
        {
            // time to change!
            timeLeft = interval;
            lt.spotAngle += (82/100f)*5/60f;
        }
        }
    }
}