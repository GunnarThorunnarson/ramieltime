using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ramielScore : MonoBehaviour {

    //skripta fyrir UI: score
    public static int score = 0;
    public Text scoreText;

    void Update()
    {
        score = cubeHealth.points;
        scoreText.text = "Score : " + score;
    }
}
