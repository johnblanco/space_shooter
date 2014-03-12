using UnityEngine;
using System.Collections;

public class EnemiesSWave : Wave
{
    public GameObject enemy;

    void Start()
    {
    
    }
    
    public override void SpawnObject(int currentIndex)
    {
        GameObject instantiated = Instantiate(enemy, new Vector3(-6, 0, 24), Quaternion.identity) as GameObject;
        iTween.MoveTo(instantiated, iTween.Hash("path", iTweenPath.GetPath("SLeftToRight"), "orienttopath", true, "time", 5,
         "easetype", iTween.EaseType.easeInOutSine));
    }
}
