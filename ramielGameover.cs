using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ramielGameover : MonoBehaviour {

    //skripta fyrir UI: game over

    bool over = false;
    public Text gameoverText;

    void Update()
    {
        over = ramielHealth.gameOver;
        if (over == true)
        {
            gameoverText.text = "GAME OVER";
        }

    }
}
