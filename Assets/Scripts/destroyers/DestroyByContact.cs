using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
  public GameObject explosion;
  public int scoreValue;
  private GameController gameController;
  public GameObject healthBox;
  public GameObject weaponBox;

  //los components que tienen attached este script son: enemigos, asteroides y bala de enemigo

  void Start()
  {
    GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
    if (gameControllerObject != null){
      gameController = gameControllerObject.GetComponent <GameController>();
    }
    if (gameController == null){
      Debug.Log("Cannot find 'GameController' script");
    }
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Boundary" || other.tag == "Enemy" || other.tag == "LootBox" || other.tag == "Bullet"){
      return;
    }

    if (explosion != null){
      Instantiate(explosion, transform.position, transform.rotation);
    }

    if (other.tag == "Player"){
      gameController.HitPlayer(34,other.gameObject.GetComponent<PlayerController>());
    } else{
      Destroy(other.gameObject);
      MaybeGiveLoot();
    }

      gameController.AddScore(scoreValue);
      Destroy(gameObject);
    }

    void MaybeGiveLoot()
    {
      if (healthBox != null && weaponBox != null)
      {
        bool hasToSpawn = true;
        if (hasToSpawn){
          bool isHealth = Random.Range(0, 100) % 2 == 0;
          if (isHealth)
            Instantiate(healthBox, transform.position, transform.rotation);
          else
            Instantiate(weaponBox, transform.position, transform.rotation);     
        }
      }
    }
  }