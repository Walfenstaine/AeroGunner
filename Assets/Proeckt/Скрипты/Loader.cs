using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene(YandexGame.savesData.lvl);
        //YandexGame.ResetSaveProgress();
        YandexGame.SaveProgress();
    }
}
