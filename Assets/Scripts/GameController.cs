using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
  public GameObject playerExplosion;
  public GameObject player;
  public GameObject player2;
  public GameObject energyBar2Wrapper;
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
  public int playerHealth;
  public int playerHealth2;
  private bool gameOver;
  private bool restart;
  private int score;
  private TwoPlayerFlag twoPlayerFlag;
  private bool twoPlayerGame;

  void Start()
  {

    gameOver = false;
    restart = false;
    twoPlayerGame = false;
    restartText.text = "";
    gameOverText.text = "";
    score = 0;
    UpdateScore();
    StartCoroutine(SpawnWaves());
    if(GameObject.Find("2PlayerFlag") != null){
      twoPlayerFlag = GameObject.Find("2PlayerFlag").GetComponent <TwoPlayerFlag>();  
      twoPlayerGame = twoPlayerFlag.twoPlayerGame;

    }
    player2.SetActive(twoPlayerGame);
    energyBar2Wrapper.SetActive(twoPlayerGame);

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
  }

  IEnumerator SpawnWaves()
  {
    yield return new WaitForSeconds(startWait);
    while (true)
    {
      for (int i = 0; i < hazardCount; i++)
      {
        GameObject hazard = hazards [Random.Range(0, hazards.Length)];
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(hazard, spawnPosition, spawnRotation);
        yield return new WaitForSeconds(spawnWait);
      }
      yield return new WaitForSeconds(waveWait);

      if (gameOver)
      {
        restartText.text = "Press 'R' for Restart";
        restart = true;
        break;
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

  public void RestoreHealth(int healthPoints)
  {
    playerHealth = Mathf.Clamp(playerHealth + healthPoints, 0, 100);
    energyBar.health = playerHealth;
  }

  public void HitPlayer(int hitPoints)
  {
    playerHealth = Mathf.Clamp(playerHealth-hitPoints,0,100);
    energyBar.health = playerHealth;
    if (playerHealth == 0)
    {
      Destroy(player);
      Instantiate(playerExplosion, player.transform.position, player.transform.rotation);
      if(playerHealth2 <= 0 || !twoPlayerGame)
        GameOver();
    }
  }
  public void HitPlayer2(int hitPoints)
  {
    playerHealth2 = Mathf.Clamp(playerHealth2-hitPoints,0,100);
    energyBar2.health = playerHealth2;
    if (playerHealth2 <= 0)
    {
      Destroy(player2);
      Instantiate(playerExplosion, player2.transform.position, player2.transform.rotation);
      if(playerHealth <= 0 )
        GameOver();
    }
  }

  public void GiveWeapon()
  {

    PlayerController pController = player.GetComponent<PlayerController>();

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