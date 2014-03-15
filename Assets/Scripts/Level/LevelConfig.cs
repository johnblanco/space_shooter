using UnityEngine;
using System.Collections;

public class LevelConfig : MonoBehaviour
{

    public int targetScore;
    public int targetEnemyKills;
    public GameController gameController;
    
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController") as GameObject;
        this.gameController = gameControllerObject.GetComponent<GameController>();
    }
}
