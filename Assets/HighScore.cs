using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text highScoreText;

    void Start()
    {
        //highScoreText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        highScoreText.text = Score.scoreAmount/4 +"";
    }
}
