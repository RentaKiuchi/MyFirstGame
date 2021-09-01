using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float amplitude= 0.01f; // �U��
    private int frameCnt = 0; // �t���[���J�E���g
    void FixedUpdate()
    {
        frameCnt += 1;
        if (10000 <= frameCnt)
        {
            frameCnt = 0;
        }
        if (0 == frameCnt % 2)
        {
            // �㉺�ɐU��������i�ӂ�ӂ��\���j
            float posYSin = Mathf.Sin(2.0f * Mathf.PI * (float)(frameCnt % 200) / (200.0f - 1.0f));
            iTween.MoveAdd(gameObject, new Vector3(amplitude * posYSin, 0, 0), 0.0f);
        }
    }
}