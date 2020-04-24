using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Configuration")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 3f;

    public GameObject getEnemyPrefab() { return enemyPrefab; }
    public GameObject getPathPrefab() { return pathPrefab; }
    public float getTimeBetweenSpawns() { return timeBetweenSpawns; }
    public float getSpawnRandomFactor() { return spawnRandomFactor; }
    public float getNumberOfEnemies() { return numberOfEnemies; }
    public float getMoveSpeed() { return moveSpeed; }
}
