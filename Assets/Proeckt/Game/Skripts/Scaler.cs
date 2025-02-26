using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public static event Action<Vector3> ded;
    private void FixedUpdate()
    {
        if (Vector3.Distance(Ball.regid.transform.position, transform.position) > Screen.height+100) {
            ded.Invoke(Ball.regid.transform.position);
            Destroy(gameObject);
        }
    }
}
