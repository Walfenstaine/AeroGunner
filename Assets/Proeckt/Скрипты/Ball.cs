using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200;
    public Rigidbody2D rb;
    public Vector3 forse;

    private void FixedUpdate()
    {
        rb.velocity = forse * speed;
    }
}
