using UnityEngine;
using System.Collections;

public class RedEnemyMoverPathFollower : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("RightToLeft"), "time", 5, "easetype", iTween.EaseType.easeInOutSine,
        "orienttopath", true));
    }
    
}
