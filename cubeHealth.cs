using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeHealth : MonoBehaviour {

    public int health;
    private int currentHealth;
    public static int points = 0;
    public static float killcount;


    void Start()
    {
        currentHealth = health;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            killcount++;
            points += PlayerMovement.multi * 50;
        }

        if (killcount == 30)
        {
            PlayerMovement.level = 2;
        }

        if (killcount >= 60)
        {
            PlayerMovement.level = 3;
            killcount = 60;
        }
    }


    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
