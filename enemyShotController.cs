using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShotController : MonoBehaviour
{
    public float shotLifetime;
    public static int damageDealt = 1;

    void Start()
    {

    }

    void Update()
    {

        shotLifetime -= Time.deltaTime;
        if (shotLifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<ramielHealth>().HurtPlayer(damageDealt);
        }

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
