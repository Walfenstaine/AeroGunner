using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public List<GameObject> gameObjects;
    public static Counter regit { get; set; }

    void Awake()

    {
        if(regit == null)
        {
            regit = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void OnDestroy()

    {
        regit = null;
    }
}
    