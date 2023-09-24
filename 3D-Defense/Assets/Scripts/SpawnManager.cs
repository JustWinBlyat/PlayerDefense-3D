using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;
    public float spawnRange = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void SpawnEnemy()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(spawnPosX, 0, spawnPosZ);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }    
}
