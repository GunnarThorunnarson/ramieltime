using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MovementLimit
{
    public float xMin, xMax, zMin, zMax;
}


public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public MovementLimit boundary;
    public float shotSpeed;
    public Rigidbody shot;
    public Transform shotSpawn1;
    public Transform shotSpawn2;
    public Transform shotSpawn3;
    public float counter;
    public float delay;
    public static float level = 1;
    public static int multi;
    public AudioSource lasershot;


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3
            (
             Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
             0.0f,
             Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
            );
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            

            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                counter = delay;
                if (level == 1)
                {
                    spawner.spawnDelayutafegkannekkibetrileid = 1;
                    enemyController.enemySpeed = 300;
                    hurtRamiel.enemyShotSpeed = 400;
                    shotController.damageDealt = 1;
                    multi = 1;
                    shotSpeed = 300;
                    speed = 10;
                    Rigidbody shotInstance;
                    shotInstance = Instantiate(shot, shotSpawn1.position, shotSpawn1.rotation);
                    shotInstance.AddForce(shotSpawn1.forward * shotSpeed);
                    lasershot.Play();
                }

                if (level == 2)
                {
                    spawner.spawnDelayutafegkannekkibetrileid = 0.7;
                    enemyController.enemySpeed = 500;
                    hurtRamiel.enemyShotSpeed = 600;
                    shotController.damageDealt = 2;
                    multi = 2;
                    shotSpeed = 600;
                    speed = 12;
                    Rigidbody shotInstance;
                    shotInstance = Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
                    shotInstance.AddForce(shotSpawn2.forward * shotSpeed);
                    shotInstance = Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
                    shotInstance.AddForce(shotSpawn3.forward * shotSpeed);
                }

                if (level == 3)
                {
                    spawner.spawnDelayutafegkannekkibetrileid = 0.5;
                    enemyController.enemySpeed = 700;
                    hurtRamiel.enemyShotSpeed = 800;
                    shotController.damageDealt = 3;
                    multi = 3;
                    shotSpeed = 1000;
                    speed = 15;
                    Rigidbody shotInstance;
                    shotInstance = Instantiate(shot, shotSpawn1.position, shotSpawn1.rotation);
                    shotInstance.AddForce(shotSpawn1.forward * shotSpeed);
                    shotInstance = Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
                    shotInstance.AddForce(shotSpawn2.forward * shotSpeed);
                    shotInstance = Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
                    shotInstance.AddForce(shotSpawn3.forward * shotSpeed);
                }
            }
        }

        else
        {
            counter = 0;
        }

        
    }
}