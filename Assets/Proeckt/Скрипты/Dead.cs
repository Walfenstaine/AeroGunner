using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public int health;
    public GameObject[] quantityBall;
    public GameObject reclamButon;
    private void Start()
    {
        Ball.regit.Stoped(Player.regit.starter.position);
    }
    public void Add_Live() 
    {
        if (health < 3) 
        {
            health += 1;
            for (int i = 0; i < quantityBall.Length; i++)
            {
                if (i < health)
                {
                    quantityBall[i].SetActive(true);
                }
                else
                {
                    quantityBall[i].SetActive(false);
                }
            }
        }
    }
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
    private void FixedUpdate()
    {
        if (health < 3)
        {
            reclamButon.SetActive(true);
        }
        else 
        {
            reclamButon.SetActive(false);
        }
    }
    void Beginning()

    {
        if(health > 0)
        {
            Ball.regit.Stoped(Player.regit.starter.position);
            Interface.rid.Sum(0);
        }
        else
        {
            Interface.rid.Sum(2);
        }
    }

}
