using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;
//using YG;
public class LavelAnd : MonoBehaviour {
	public string level;
    public static LavelAnd rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Reklama;
    }
    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Reklama;
    }
    public void Reload()
    {
        YandexGame.savesData.record = 0;
        YandexGame.savesData.coins = 0;
        YandexGame.SaveProgress();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartAds(int index) 
    {
        YandexGame.RewVideoShow(index);
    }
    void Reklama(int index)
    {
        if (index == 0)
        {
            Interface.rid.Sum(0);
            YandexGame.savesData.coins += 100;
            YandexGame.SaveProgress();
            Ball.regid.rb.bodyType = RigidbodyType2D.Dynamic;
            
        }
        else {
            YandexGame.savesData.coins += 100;
            YandexGame.SaveProgress();
        }
    }

    public void Next()
    {
        SceneManager.LoadScene(level);
    }
}
