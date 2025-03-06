using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block_Helse : MonoBehaviour
{
    public Sprite[] sprites;
    public Image img;
    public int helse;
    float timer = 0;

    void Start()

    {
        helse = Random.Range(0, sprites.Length);
        Counter.regit.gameObjects.Add(gameObject);
    }

    public void Damage() 

    {
        if (Time.time >= timer) 
        {
            timer = Time.time + 0.2f;
            if (helse > 0)
            {
                helse -= 1;
            }
            else 
            {
                Counter.regit.gameObjects.Remove(gameObject);
                Destroy(gameObject);
            }
        }
       
    }

    void FixedUpdate()

    {
        img.sprite = sprites[helse];
    }

}
