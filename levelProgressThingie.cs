using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelProgressThingie : MonoBehaviour
{

    public Image progress;
    public Text ratioText;

    void Start()
    {

    }

    void Update()
    {
        if (PlayerMovement.level == 1)
        {
            float ratio = cubeHealth.killcount / 30;
            progress.rectTransform.localScale = new Vector3(ratio, 1, 1);
            ratioText.text = (ratio * 100).ToString() + "%";
        }

        if (PlayerMovement.level == 2)
        {
            float ratio = cubeHealth.killcount / 60;
            progress.rectTransform.localScale = new Vector3(ratio, 1, 1);
            ratioText.text = (ratio * 100).ToString() + "%";
        }

        if (PlayerMovement.level == 3)
        {
            ratioText.text = "MAX POWER";
        }
        
    }
}
