using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{

    public GameObject[] obj;
    public int sizeCoeficient = 5;
    public float groundRadius = 0.3f;
    public LayerMask groundMask;

    private void OnEnable()
    {
        Scaler.ded += Creat;
    }
    private void OnDisable()
    {
        Scaler.ded -= Creat;
    }
    void Start()
    {
        for (var i = 0; i < Screen.width / sizeCoeficient; i++)
        {
            float randomX = Random.Range(-Screen.width, Screen.width);
            float randomY = Random.Range(-Screen.height, Screen.height);

            var rand = Random.Range(0, 3);
            GameObject g = Instantiate(obj[rand]);
            g.transform.SetParent(transform);
            g.transform.position = new Vector2(randomX, randomY);
        }

    }
    void Creat(Vector3 v) 
    {
        float randomX = Random.Range(-Screen.width, Screen.width);
        float randomY = Random.Range(-Screen.height, Screen.height);

        var rand = Random.Range(0, 3);
        GameObject g = Instantiate(obj[rand]);
        g.transform.SetParent(transform);
        g.transform.position = new Vector2(v.x + randomX, v.y + randomY);
    }
}
