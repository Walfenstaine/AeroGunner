using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200;
    public Rigidbody2D rb;
    public Vector3 forse;
    public bool active;
    public static Ball regit { get; set; }
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
    public void Started() 
    {
        active = true;
    }
    public void Stoped(Vector3 t) 
    {
        active = false;
        transform.position = t;
    }
    private void FixedUpdate()
    {
        if (active)
        {
            rb.velocity = forse * speed;
        }
        else 
        {
            rb.velocity = Vector3.zero;
            transform.position = Player.regit.starter.position;
        }
    }
}
