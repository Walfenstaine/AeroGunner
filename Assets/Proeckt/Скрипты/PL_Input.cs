using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL_Input : MonoBehaviour
{
    private void Update()
    {
        Player.regit.nap = Input.GetAxis("Horizontal");
    }
}
