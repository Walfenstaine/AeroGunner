using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using YG;

public class Ball : MonoBehaviour
{
    public Transform cam, bodey;
    public Animator anim;
    public float forse;
    public Vector3 nap;
    public Rigidbody2D rb;
    float timer = 0;
    public static Ball regid;

    void Awake()
    {

        if (regid == null)
        {
            regid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        regid = null;
    }
    public void Onclick() 
    {

        float x = Screen.width/2 - Input.mousePosition.x;
        float y = Screen.height/2 - Input.mousePosition.y;
        Vector2 mp = new Vector2(x,y);
        nap = Vector3.Normalize(mp);
        rb.AddForce(nap * forse * 1000);
        KIk();
    }

    public void KIk() 
    {
        if (timer < Time.time) 
        {
            timer = Time.time + 0.2f;
            anim.SetTrigger("Kik");
        }
        
    }
    public void Damage() 
    {
        if (Time.time > 2) 
        {
            if (YandexGame.savesData.coins > 0)
            {
                YandexGame.savesData.coins -= 1;
                YandexGame.SaveProgress();
            }
            else
            {
                Interface.rid.Sum(2);
                rb.bodyType = RigidbodyType2D.Static;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        KIk();
    }
    private void Update()
    {
        //if (rb.velocity.magnitude > 0) 
        // {
        //  bodey.up = Vector3.Lerp(bodey.up, rb.velocity,0.1f * Time.deltaTime);
        // }

        //cam.position =  Vector3.Lerp( cam.position, transform.position+(new Vector3(rb.velocity.x, rb.velocity.y/2,0)), 4 * Time.deltaTime);
        cam.position = transform.position;
    }
}
