using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class Glass_Object : MonoBehaviour
{
    public Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            anim.SetTrigger("Ded");

        }
    }
    public void Ded() 
    {
        if (Time.time > 1) 
        {
            YandexGame.savesData.record += 1;
            YandexGame.savesData.coins += 1;
            YandexGame.SaveProgress();
            YandexGame.NewLeaderboardScores("LEADER666", YandexGame.savesData.record);
        }
        
        Destroy(gameObject);
    }
}
