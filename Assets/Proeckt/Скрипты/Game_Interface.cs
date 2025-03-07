using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
public class Game_Interface : MonoBehaviour
{
    public Text record, blocs;
    private void FixedUpdate()
    {
        record.text = "" + YandexGame.savesData.record;
        blocs.text = "" + Counter.regit.gameObjects.Count;
    }
}
