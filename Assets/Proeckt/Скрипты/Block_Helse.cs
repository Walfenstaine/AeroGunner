using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
public class Block_Helse : MonoBehaviour
{
    public Sprite[] sprites;
    public Image img;
    public int helse;
    float timer = 0;
    int rec;
    void Start()

    {
       
        helse = Random.Range(0, sprites.Length);
        rec = helse;
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
                if (Counter.regit.gameObjects.Count > 1)
                {
                    Counter.regit.gameObjects.Remove(gameObject);
                }
                else { Interface.rid.Sum(3); }
                YandexGame.savesData.record += rec;
                YandexGame.NewLeaderboardScores("LEADER666", YandexGame.savesData.record);
                YandexGame.SaveProgress();
                Destroy(gameObject);
            }
        }
       
    }

    void FixedUpdate()

    {
        img.sprite = sprites[helse];
    }

}
