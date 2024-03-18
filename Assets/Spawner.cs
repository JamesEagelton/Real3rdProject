using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    

   

    public void SpawnEnemy() 
    {
        int spawnx = Random.Range(10, -10);
        int spawny = Random.Range(0, 0);
        int spawnz = Random.Range(10, -10);

        Vector3 spawnpos = new Vector3 (spawnx, spawny, spawnz);

        Instantiate(enemy, spawnpos, Quaternion.identity);
    }
}
