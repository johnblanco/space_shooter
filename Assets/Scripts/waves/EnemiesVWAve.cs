using UnityEngine;
using System.Collections;

public class EnemiesVWAve : Wave
{

    public GameObject[] enemies;

    void Start()
    {
        spawnValues = new Vector3(0f, 0f, 16f);
    }

    public override void SpawnObject(int currentIndex)
    {
        
        GameObject enemy = enemies [currentIndex % enemies.Length];
        Vector3 spawnPosition;
        GameObject instantiated;
//        if (currentIndex % 2 == 0)
//        {// spawn right
        if (currentIndex == 0)
        { 
            spawnPosition = spawnValues;
            instantiated = GameObject.Instantiate(enemy, spawnPosition, Quaternion.identity) as GameObject;
            GameObject.DestroyImmediate(instantiated.GetComponent<EvasiveManeuver>(), true);
        
        } else
        {
            spawnPosition = new Vector3(spawnValues.x + 4f, spawnValues.y, spawnValues.z);
            instantiated = GameObject.Instantiate(enemy, spawnPosition, Quaternion.identity) as GameObject;
            GameObject.DestroyImmediate(instantiated.GetComponent<EvasiveManeuver>(), true);
                
            spawnPosition = new Vector3(spawnValues.x - 4f, spawnValues.y, spawnValues.z);
            instantiated = GameObject.Instantiate(enemy, spawnPosition, Quaternion.identity) as GameObject;
            GameObject.DestroyImmediate(instantiated.GetComponent<EvasiveManeuver>(), true);
        
        }
            
//        } else
//        { // spawn left
//            spawnPosition = new Vector3(spawnValues.x - 4f, spawnValues.y, spawnValues.z);
//        }
//        GameObject instantiated = GameObject.Instantiate(enemy, spawnPosition, Quaternion.identity) as GameObject;
//        GameObject.DestroyImmediate(instantiated.GetComponent<EvasiveManeuver>(), true);
//        
    }
 
}
