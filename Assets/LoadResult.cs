using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadResult : MonoBehaviour
{
    public Camera targetObj;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void EndGame()
    {
        Invoke("Result", 1);
    }

    void Result()
    {
        Destroy(targetObj);
        SceneManager.LoadScene("result");
    }
}
