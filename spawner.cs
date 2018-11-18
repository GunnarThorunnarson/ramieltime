using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    //skripta sem sér um að spawna óvini

    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnDelay;
    public float spawnMaxDelay;
    public float spawnMinDelay;
    public float startDelay;
    public bool stop;
    public static double spawnDelayutafegkannekkibetrileid;
    


    void Start()
    {
        StartCoroutine(delaySpawner());
    }

    void Update()
    {
        spawnDelayutafegkannekkibetrileid = spawnMaxDelay;
        spawnDelay = Random.Range(spawnMinDelay, spawnMaxDelay);
    }

    IEnumerator delaySpawner()
    {
        yield return new WaitForSeconds(startDelay);

        while (!stop)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(enemies[0], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
