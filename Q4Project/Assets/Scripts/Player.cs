using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    // Physics Variables
    public double xspeed;
    public double yspeed;
    public double stopspeed;
    public double gravity;
    public double jumpforce;

    // Update is called once per frame
    void Update()
    {
        if(InputMan.buttonA)
        {
            xspeed = xspeed - 0.3;
            xspeed = Math.Clamp(xspeed, -3, 3);
        }
    }
}
