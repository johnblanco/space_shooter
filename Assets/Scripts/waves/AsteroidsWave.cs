
using System;
using UnityEngine;

public class AsteroidsWave : Wave
{
  public GameObject[] asteroids;
  public Vector3 spawnValues;

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
    Vector3 spawnPosition = new Vector3(wrapPosition(-spawnValues.x, spawnValues.x, currentIndex), spawnValues.y, spawnValues.z);
    
    GameObject.Instantiate(asteroid, spawnPosition, Quaternion.identity);
  }
  
  private float wrapPosition(float xMin, float xMax, float value)
  {
    float intervalLenth = xMax - xMin;
    float result = xMin + (value % intervalLenth);
    Debug.Log(result);
    return result;
  }
}


