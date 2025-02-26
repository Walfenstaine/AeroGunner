using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
public class Scores : MonoBehaviour
{
    public Text score, coins;

    private void FixedUpdate()
    {
        score.text = "" + YandexGame.savesData.record;
        coins.text = "" + YandexGame.savesData.coins;
    }
}
