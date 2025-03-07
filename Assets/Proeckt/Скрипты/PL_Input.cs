using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
       // if (Ball.regit.active) {  }
        Muve(Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) { Started(); }
    }
}
