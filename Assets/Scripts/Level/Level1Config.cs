using UnityEngine;
using System.Collections;

public class Level1Config : LevelConfig
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
            GameObject.FindGameObjectWithTag("LevelController").GetComponent<PlayMakerFSM>().SendEvent("level 1 finished");
        }
    }
}
