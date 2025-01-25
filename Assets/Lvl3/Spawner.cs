using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject item;
    

    void Start()
    {
        InvokeRepeating("SpawnItem", 0f, 10f);
    }

    public void SpawnItem()
    {
        int spawnPointX = Random.Range(-17, 17);
        int spawnPointY = Random.Range(0, 1);
        int spawnPointZ = Random.Range(-17, 17);

        Vector3 spawnPosition = new Vector3 (spawnPointX, spawnPointY, spawnPointZ);
        Instantiate(item, spawnPosition, Quaternion.identity);
    }

}
