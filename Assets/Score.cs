using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int scoreAmount;
    public Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
    }
    // Update is called once per frame
    void Update () {
        scoreText.text = scoreAmount/4+"";
	}
}
