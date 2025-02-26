using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEvent : MonoBehaviour
{
    public UnityEvent clic;

    public void OnCliker() 
    {
        clic.Invoke();
    }
}
