using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Shabon; //�I�u�W�F�N�g���i�[����z��ϐ�
    private float time; //�o������Ԋu�𐧌䂷�邽�߂̕ϐ�
    private int number; //�����_���������邽�߂̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        time = 1.0f; //���Ԃ�҂����A�ŏ���1����o��
    }

    // Update is called once per frame
    void Update()
    {
        int index = Random.Range(-25,10);
        time -= Time.deltaTime; //time���玞�Ԃ����炷
        if (time <= 0.0f) //0�b�ɂȂ��
        {
            time = 0.7f; //1�b�ɂ���
            number = Random.Range(0, Shabon.Length); //Random.Range (�ŏ��l, �ő�l) �����̏ꍇ�͍ő�l�͏��O
            Instantiate(Shabon[number], new Vector3(index,16, 20), Quaternion.identity); //X���W-10�Ƀ����_���o���A�����̐ݒ�͖���
        }
    }
}
