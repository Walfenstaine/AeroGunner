using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using UnityEngine.ProBuilder.Shapes;
using YG;

public class Interface : MonoBehaviour
{
    public float globalSpeed;
    public UnityEvent[] sumer;
    public static Interface rid { get; set; }
    void Awake()
    {
        Sum(0);

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
    public void Sum(int index)
    {
        sumer[index].Invoke();
        Time.timeScale = 1;
    }
}