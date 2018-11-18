using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramielHealth : MonoBehaviour {

    public static int currentHealth;
    public int startHealth;
    public static bool gameOver;

	void Start ()
    {
        currentHealth = startHealth;
    }
	
	void Update ()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            Time.timeScale = 0;
            gameOver = true;
        }
    }

    public void HurtPlayer(int damageAmount)
    {

        currentHealth -= damageAmount;
    }
}
