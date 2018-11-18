using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtRamiel : MonoBehaviour {

    public int damageDealt;
    public Rigidbody enemyShot;
    public Transform enemyShotSpawn;
    public static int enemyShotSpeed = 500;
    public float enemyShotDelay;
    public float enemyShotDelayExternal;


    public void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<ramielHealth>().HurtPlayer(damageDealt);
            PlayerMovement.level = 1;
            cubeHealth.killcount = 0;
        }

        if (other.gameObject.tag == "Clear")
        {
            Destroy(gameObject);
        }       
    }

    public void Update()
    {
        enemyShotDelay -= Time.deltaTime;

        if (enemyShotDelay <= 0)
        {
            Rigidbody enemyshotInstance = Instantiate(enemyShot, enemyShotSpawn.position, enemyShotSpawn.rotation);
            enemyshotInstance.AddForce(enemyShotSpawn.forward * enemyShotSpeed);
            enemyShotDelay = enemyShotDelayExternal;
        }
    }
}
