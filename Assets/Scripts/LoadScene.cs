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
        Invoke("scene", 1); 
    }

    public void goTItle()
    {
        Invoke("Title", 1);
    }

    public void Tutorial()
    {
        Invoke("Tokui", 1);
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