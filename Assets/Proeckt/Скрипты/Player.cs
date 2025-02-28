using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float nap;
    public Transform starter;
    public static Player regit { get; set; }
    private void Awake()
    {
        if (regit == null)
        {
            regit = this;
        }
        else 
        {
            Destroy(regit);
        }
    }
    private void OnDestroy()
    {
        Destroy(regit);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(nap, 0, 0)* 200;
    }
}
