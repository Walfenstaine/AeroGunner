using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class PL_Input : MonoBehaviour
{
    void Started() 
    {
        if (!Ball.regit.active)
        {
            if (Player.regit.nap != 0)
            {
                Interface.rid.Sum(1);
                Ball.regit.Started();
            }

        }
    }
    void Muve(float m) 
    {
        Player.regit.nap = m;      
    }
    private void Update()
    {
        if (YandexGame.EnvironmentData.deviceType == "desktop")
        {
            Muve(Input.GetAxis("Horizontal"));
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) { Started(); }
        }
        else 
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    Started();
                    Muve((touch.deltaPosition.x / Screen.width) * -100);
                }
            }
            else { Player.regit.nap = 0; }
        }
    }
}
