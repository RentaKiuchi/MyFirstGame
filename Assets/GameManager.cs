using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Shabon; //オブジェクトを格納する配列変数
    private float time; //出現する間隔を制御するための変数
    private int number; //ランダム情報を入れるための変数
    // Start is called before the first frame update
    void Start()
    {
        time = 1.0f; //時間を待たず、最初の1回を出現
    }

    // Update is called once per frame
    void Update()
    {
        int index = Random.Range(-25,10);
        time -= Time.deltaTime; //timeから時間を減らす
        if (time <= 0.0f) //0秒になれば
        {
            time = 0.7f; //1秒にする
            number = Random.Range(0, Shabon.Length); //Random.Range (最小値, 最大値) 整数の場合は最大値は除外
            Instantiate(Shabon[number], new Vector3(index,16, 20), Quaternion.identity); //X座標-10にランダム出現、向きの設定は無し
        }
    }
}
