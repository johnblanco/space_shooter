using UnityEngine;
using System.Collections;

public class Level2Config : LevelConfig
{

    public void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController") as GameObject;
        this.gameController = gameControllerObject.GetComponent<GameController>();
    }
    
    void FixedUpdate()
    {
        if (this.gameController.score >= targetScore)
        {
            GameObject.FindGameObjectWithTag("LevelController").GetComponent<PlayMakerFSM>().SendEvent("level 2 finished");
        }
    }
}
