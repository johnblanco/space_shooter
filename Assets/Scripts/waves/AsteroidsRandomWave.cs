using UnityEngine;
using System.Collections;

public class AsteroidsRandomWave : Wave
{
    public GameObject[] asteroids;

    void Start()
    {
	
    }
	
    public override void SpawnObject(int currentIndex)
    {
        GameObject original = asteroids [currentIndex % asteroids.Length];
        
        GameObject instantiated = Instantiate(original, new Vector3(Random.Range(-7, 7), 0, 16), Quaternion.identity) as GameObject;
        instantiated.GetComponent<ZMover>().speed = Random.Range(-4, -7);
    }
}
