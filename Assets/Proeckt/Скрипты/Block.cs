using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Bord;

public class Block : MonoBehaviour
{
    public GameObject des;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(des);
        }
    }
}
