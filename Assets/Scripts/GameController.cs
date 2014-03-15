using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    public PlayerController player1;
    public PlayerController player2;
    public GameObject playerExplosion;
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;
    public EnergyBar energyBar;
    public EnergyBar energyBar2;
    private bool gameOver;
    private bool restart;
    public int score;

    void Start()
    {

        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

        if (player1.health == 0 && player2.health == 0)
        {
            GameOver();
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
//              for (int i = 0; i < hazardCount; i++)
//                {
//                  GameObject hazard = hazards [Random.Range(0, hazards.Length)];
//                  Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
//                  Quaternion spawnRotation = Quaternion.identity;
//                  Instantiate(hazard, spawnPosition, spawnRotation);
//                  yield return new WaitForSeconds(spawnWait);
//                }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                yield return new WaitForSeconds(startWait);
                while (true)
                {
//                      for (int i = 0; i < hazardCount; i++)
//                        {
//                          GameObject hazard = hazards [Random.Range(0, hazards.Length)];
//                          Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
//                          Quaternion spawnRotation = Quaternion.identity;
//                          Instantiate(hazard, spawnPosition, spawnRotation);
//            
//                          yield return new WaitForSeconds(spawnWait);
//                        }
                    yield return new WaitForSeconds(waveWait);
              
                    if (gameOver)
                    {
                        restartText.text = "Press 'R' for Restart";
                        restart = true;
                        break;
                    }
                }
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

    public void RestoreHealth(int healthPoints, PlayerController player)
    {
        player.health = Mathf.Clamp(player.health + healthPoints, 0, 100);
    }

    public void HitPlayer(int hitPoints, PlayerController damagedPlayer)
    {
        damagedPlayer.health = Mathf.Clamp(damagedPlayer.health - hitPoints, 0, 100);
        if (damagedPlayer.health == 0)
        {
            Instantiate(playerExplosion, damagedPlayer.transform.position, damagedPlayer.transform.rotation);
            Destroy(damagedPlayer.gameObject);
            if (damagedPlayer.isPlayer2)
            {
                energyBar2.health = 0;
            } else
            {
                energyBar.health = 0;
            }

        }
    }

    public void GiveWeapon(PlayerController pController)
    {
        if (pController.currentWeapon is SimpleGun)
        { 
            pController.currentWeapon = new TripleGun(pController.shotSpawn);
            return;
        }

        if (pController.currentWeapon is TripleGun)
        {
            pController.currentWeapon = new GuidedMissile(pController.shotSpawn);
            return;
        }

        if (pController.currentWeapon is GuidedMissile)
        {
            pController.currentWeapon = new SimpleGun(pController.shotSpawn);
            return;
        }

    }
}