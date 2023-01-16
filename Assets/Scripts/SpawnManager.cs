using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    bool mustSpawn;

    float spawnRangeX = 9;
    float spawnPosZ = 20;
    float timeToSpawn = 4f;
    float spawnRatio = 0.8f;
    float makeHarderTime = 8f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 0.5f);
        Invoke("MakeHarder", makeHarderTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(mustSpawn)
        {
            Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(
                animalPrefabs[animalIndex],
                spawnPos,
                animalPrefabs[animalIndex].transform.rotation
            );
            mustSpawn = false;
        }
    }
    void Spawn()
    {
        mustSpawn = true;
        Invoke("Spawn", timeToSpawn);
    }
    void MakeHarder()
    {
        timeToSpawn = timeToSpawn * spawnRatio;
        Invoke("MakeHarder", makeHarderTime);
    }
}
