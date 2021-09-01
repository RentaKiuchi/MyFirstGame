using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RANK : MonoBehaviour
{
    int scorer;
    public Text rankText; //Textópïœêî
    // Start is called before the first frame update
    void Start()
    {
        scorer = CursorShotScript.getscore();
        if (scorer <= 2000)
            rankText.text = string.Format("RANK : ò_äO");
        else if (scorer <= 20000)
            rankText.text = string.Format("RANK : D");
        else if (scorer <= 30000)
            rankText.text = string.Format("RANK : C");
        else if (scorer <= 35000)
            rankText.text = string.Format("RANK : B");
        else if (scorer <= 40000)
            rankText.text = string.Format("RANK : A");
        else if (scorer <= 50000)
            rankText.text = string.Format("RANK : S");
        else
        {
            rankText.text = string.Format("RANK : É∂");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
