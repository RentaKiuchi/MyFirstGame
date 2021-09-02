using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        FadeManager.Instance.LoadScene("count", 0.5f);
    }

    public void goTItle()
    {
        FadeManager.Instance.LoadScene("Title", 0.5f);
    }

    public void Tutorial()
    {
        FadeManager.Instance.LoadScene("tutorial", 0.5f);
    }
    void scene()
    {
        SceneManager.LoadScene("count");
    }

    void Title()
    {
        SceneManager.LoadScene("Title");
    }

    void Tokui()
    {
        SceneManager.LoadScene("tutorial");
    }
}
