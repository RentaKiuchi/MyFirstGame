using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rupture : MonoBehaviour
{
    [SerializeField] ParticleSystem tapEffect;
    [SerializeField] Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);
        tapEffect.transform.position = pos;
    }
    }

