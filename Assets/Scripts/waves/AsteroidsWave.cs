
using System;
using UnityEngine;

public class AsteroidsWave : Wave
{
  public GameObject[] asteroids;

  public AsteroidsWave()
  {
    
  }
  
  public void Start()
  {
    spawnValues = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().spawnValues;
  }
  
  public override void SpawnObject(int currentIndex)
  { 
    GameObject asteroid = asteroids [currentIndex % asteroids.Length];
    Vector3 spawnPosition = new Vector3(WrapPosition(-spawnValues.x, spawnValues.x, currentIndex), spawnValues.y, spawnValues.z);
    
    GameObject.Instantiate(asteroid, spawnPosition, Quaternion.identity);
  }
  
}


