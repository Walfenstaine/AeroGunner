using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class Ball : MonoBehaviour
{
    public float speed = 200;
    public Rigidbody2D rb;
    public Vector3 forse;
    public bool active;
    public static Ball regit { get; set; }
    private void Awake()
    {
        speed += YandexGame.savesData.record;
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
        rb.AddForce(forse * speed);
        active = true;
    }
    public void Stoped(Vector3 t) 
    {
        active = false;
        transform.position = t;
    }
    private void Update()
    {
        if (active)
        {
            if (rb.velocity.magnitude < speed/10)
            {
                rb.AddForce(forse * speed);
            }
            forse = rb.velocity.normalized;
        }
        else
        {
            rb.velocity = Vector3.zero;
            transform.position = Player.regit.starter.position;
            forse = new Vector3(1, 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bord") 
        {
            collision.gameObject.GetComponent<Block_Helse>().Damage();
        }
    }
}
