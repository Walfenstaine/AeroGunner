using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bord : MonoBehaviour
{
    public enum Bord_Tipe {vertical, horizontal }
    public Bord_Tipe tipe;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 p = collision.collider.ClosestPoint(transform.position)-new Vector2(transform.position.x,transform.position.y);
        if (collision.gameObject.tag == "Ball")
        {
            int y = (int)Ball.regit.forse.y;
            int x = (int)Ball.regit.forse.x;
            if (tipe == Bord_Tipe.vertical)
            {
                Ball.regit.forse.y = -y;
            }
            else
            {
                Ball.regit.forse.x = -x;
            }
        }
    }
}
