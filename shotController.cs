using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotController : MonoBehaviour {

    public float shotLifetime;
    public static int damageDealt;

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
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<cubeHealth>().HurtEnemy(damageDealt);       
        }

        if (other.gameObject.tag == "bulletClear")
        {
            Destroy(gameObject);
        }
    }
}
