using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bord : MonoBehaviour
{
    public enum Bord_Tipe {vertical, horizontal }
    public Bord_Tipe tipe;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball") 
        {
            if (tipe == Bord_Tipe.vertical)
            {
                collision.gameObject.GetComponent<Ball>().forse.y = collision.gameObject.GetComponent<Ball>().forse.y * -1;
            }
            else
            {
                collision.gameObject.GetComponent<Ball>().forse.x = collision.gameObject.GetComponent<Ball>().forse.x * -1;
            }
        }
    }
}
