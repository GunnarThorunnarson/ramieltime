using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelDisplay : MonoBehaviour {

    public Text levelText;

	void Update ()
    {
        levelText.text = "LEVEL: " + PlayerMovement.level;
	}
}
