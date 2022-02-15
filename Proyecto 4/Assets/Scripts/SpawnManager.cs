using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;

    private float spawnPositionRange = 9f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    private Vector3 RandomSpawnPosition()
    {
        float xRandom = Random.Range(-spawnPositionRange, spawnPositionRange);
        float zRandom = Random.Range(-spawnPositionRange, spawnPositionRange);

        return new Vector3(xRandom, 0, zRandom);
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, RandomSpawnPosition(), enemyPrefab.transform.rotation);
    }

    private void SpawnEnemyWave(int totalEnemy)
    {
        for (int i = 0, i < totalEnemies; i++)
        {
            SpawnEnemy()
        }
    }

}



