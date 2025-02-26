using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene("Scene1");
        //YandexGame.ResetSaveProgress();
        YandexGame.SaveProgress();
    }
}
