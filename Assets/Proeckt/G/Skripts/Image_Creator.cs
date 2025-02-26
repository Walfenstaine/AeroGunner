using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class Image_Creator : MonoBehaviour
{
    public Image picch;
    public Sprite[] sprites;

    private void FixedUpdate()
    {
        picch.sprite = sprites[YandexGame.savesData.numPicch];
    }
    public void Insert() 
    {
        YandexGame.savesData.numPicch += 1;
    }
}
