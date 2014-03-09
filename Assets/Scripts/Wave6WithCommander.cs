using UnityEngine;
using System.Collections;

public class Wave6WithCommander : Wave {
  public GameObject enemy;
  public void Start(){
    spawnValues = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().spawnValues;
  }

  public override void SpawnObject(int currentIeration){
    Vector3 spawnPosition;
    spawnPosition = new Vector3(-2,0,18);
    Instantiate(enemy, spawnPosition, Quaternion.identity);
  }
} 
