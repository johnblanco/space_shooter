using UnityEngine;
using System.Collections;

public class Wave6WithCommander : Wave
{
    public GameObject enemy;
    public GameObject heavyEnemy;

    public void Start()
    {
        spawnValues = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().spawnValues;
    }

    public override void SpawnObject(int currentIeration)
    {
        Vector3 spawnPosition;
        
        if (currentIeration == 0)
        {
            spawnPosition = new Vector3(-4, 0, 16);
            Instantiate(enemy, spawnPosition, Quaternion.identity);
            
            spawnPosition = new Vector3(4, 0, 16);
            GameObject gameObjectShip = Instantiate(enemy, spawnPosition, Quaternion.identity) as GameObject; // este lleva salud
            gameObjectShip.GetComponent<DestroyByContact>().givesHealth = true;
        } 
        
        if (currentIeration == 1)
        {
            spawnPosition = new Vector3(-6, 0, 17);
            GameObject ship = Instantiate(enemy, spawnPosition, Quaternion.identity) as GameObject; // este lleva arma!
            ship.GetComponent<DestroyByContact>().givesWeapon = true;
            
            spawnPosition = new Vector3(-2, 0, 17);
            Instantiate(enemy, spawnPosition, Quaternion.identity);
            
            spawnPosition = new Vector3(2, 0, 17);
            Instantiate(enemy, spawnPosition, Quaternion.identity);
            
            spawnPosition = new Vector3(6, 0, 17);
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
        
        if (currentIeration == 2)
        {
            spawnPosition = new Vector3(0, 0, 18);
            Instantiate(heavyEnemy, spawnPosition, Quaternion.identity);
        }
    }
} 
