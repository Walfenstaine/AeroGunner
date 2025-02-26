using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ADD_Ball : MonoBehaviour
{
    public Text cena;
    public Animator anim;
    int c;
    public void Clicker() 
    {
        if (YandexGame.savesData.numPicch < 14)
        {
            c = (YandexGame.savesData.numPicch + 1) * 100;
            if (c <= YandexGame.savesData.coins)
            {
                anim.SetTrigger("ADD");
            }
            else 
            {
                anim.SetTrigger("Out");
            }
        }
    }
    public void Insert() 
    {
        YandexGame.savesData.coins -= c;
        YandexGame.savesData.numPicch += 1;
        YandexGame.SaveProgress();

    }
    private void FixedUpdate()
    {
        if (YandexGame.savesData.numPicch >= 14) 
        {
            gameObject.SetActive(false);
        }
        cena.text = "-"+(YandexGame.savesData.numPicch+1) * 100;
    }
}
