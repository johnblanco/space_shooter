using UnityEngine;
using System.Collections;

public class Wave5Enemies : Wave {
  public GameObject enemy;
  
  public void Start()
  {
    spawnValues = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().spawnValues;
  }
  
  public override void SpawnObject(int currentIeration)
  { 
    // x     x      x
    //    x     x

    Vector3 spawnPosition;

    if(currentIeration == 0){
      spawnPosition = new Vector3(-2,0,16);
      Instantiate(enemy, spawnPosition, Quaternion.identity);

      spawnPosition = new Vector3(2,0,16);
      Instantiate(enemy, spawnPosition, Quaternion.identity);
    }else{
      spawnPosition = new Vector3(-3,0,16);
      Instantiate(enemy, spawnPosition, Quaternion.identity);

      spawnPosition = new Vector3(0,0,16);
      Instantiate(enemy, spawnPosition, Quaternion.identity);

      spawnPosition = new Vector3(3,0,16);
      Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
  }
}
