using UnityEngine;
using System.Collections;

public class AsteroidsConvexBeltWave : Wave
{
    public GameObject[] asteroids;
    
    public void Start()
    {
    
    }
    
    public override void SpawnObject(int currentIndex)
    {
        GameObject asteroid = asteroids [currentIndex % asteroids.Length];
        
        if (currentIndex == 0)
        {
            Instantiate(asteroid, new Vector3(-7, 0, 16), Quaternion.identity);
            Instantiate(asteroid, new Vector3(7, 0, 16), Quaternion.identity);
        } else if (currentIndex == 1)
        {
            Instantiate(asteroid, new Vector3(-5, 0, 15.6f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(5, 0, 15.6f), Quaternion.identity);
        } else if (currentIndex == 2)
        {
            Instantiate(asteroid, new Vector3(-3, 0, 15.3f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(3, 0, 15.3f), Quaternion.identity);
        } else if (currentIndex == 3)
        {
            Instantiate(asteroid, new Vector3(-1, 0, 15), Quaternion.identity);
            Instantiate(asteroid, new Vector3(1, 0, 15), Quaternion.identity);
        } else if (currentIndex == 4)
        {
            // Instantiate(asteroid, new Vector3(0, 0, 16), Quaternion.identity);
            //Instantiate(asteroids, new Vector3(5, 0, 16), Quaternion.identity);
        }
    }
    
}
