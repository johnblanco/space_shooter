using UnityEngine;
using System.Collections;

public class EnemiesWave : Wave
{
    public GameObject[] enemies;
  
    void Start()
    {
        spawnValues = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().spawnValues;
    }
	
    public override void SpawnObject(int currentIndex)
    { 
        GameObject enemy = enemies [currentIndex % enemies.Length];
        Vector3 spawnPosition = new Vector3(this.WrapPosition(-spawnValues.x, spawnValues.x, currentIndex), spawnValues.y, spawnValues.z);
    
        GameObject.Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
