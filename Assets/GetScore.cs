using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    int scorer;
    public Text scoreText2; //Textópïœêî
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        scorer = CursorShotScript.getscore();
        scoreText2.text = string.Format("Score:{0}", scorer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
