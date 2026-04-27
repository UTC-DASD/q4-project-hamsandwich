using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    // Physics Variables
    double xspeed;
    double yspeed;
    double stopspeed;
    double gravity;
    double jumpforce;
    // Update is called once per frame
    void Update()
    {
        
        if(InputMan.buttonA);
        {
            xspeed = xspeed - 0.3;
            xspeed = Math.Clamp(xspeed, -3, 3);
        }
    }
}
