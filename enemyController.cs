using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public static int enemySpeed = 300;
    public float lifetime;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody>().AddForce( GetComponent<Transform>().forward * enemySpeed);
    }

    public void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
