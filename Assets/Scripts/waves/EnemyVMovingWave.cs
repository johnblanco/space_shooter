using UnityEngine;
using System.Collections;

public class EnemyVMovingWave : Wave
{

    public GameObject movingEnemy;
    
    void Start()
    {
    }
    
    public override void SpawnObject(int currentIndex)
    { 
        // spawn left
        GameObject rightToLeftEnemy = Instantiate(movingEnemy, base.spawnValues, Quaternion.identity) as GameObject;
        
        iTween.MoveTo(rightToLeftEnemy, iTween.Hash("path", iTweenPath.GetPath("RightToLeft"), "time", 5, "easetype", iTween.EaseType.easeInOutSine,
                                              "orienttopath", true));
        // spawn right
        GameObject leftToRightEnemy = Instantiate(movingEnemy, base.spawnValues, Quaternion.identity) as GameObject;
        
        iTween.MoveTo(leftToRightEnemy, iTween.Hash("path", iTweenPath.GetPath("LeftToRight"), "time", 5, "easetype", iTween.EaseType.easeInOutSine,
                                           "orienttopath", true));
    }
    
}
