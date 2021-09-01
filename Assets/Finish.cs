using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Finish : MonoBehaviour
{

    void Start()
    {
        _startTime = Time.realtimeSinceStartup;
    }
    public GameObject endpanel;
  
    private float _startTime;

    void Update()
    {
        if (Time.realtimeSinceStartup - _startTime >= 30f)
        {
            endpanel.SetActive(true);
        }
    }
}
