using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public int health;
    public GameObject[] quantityBall;
    public Transform empty , ball;

    void OnTriggerEnter2D(Collider2D other)

    {
        if(other.gameObject.tag == "Ball")
        {
            health -= 1;
            for ( int i = 0; i < quantityBall.Length; i++ )
            {
                if(i < health)
                {
                    quantityBall[i].SetActive(true);
                }
                else
                {
                    quantityBall[i].SetActive(false);   
                }
            }
            Beginning();
        }
    }

    void Beginning()

    {
        if(health >= 0)
        {
            ball.position = empty.position;
        }
        else
        {

        }
    }

}
