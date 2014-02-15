using UnityEngine;
using System.Collections;

public class LootBox : MonoBehaviour {

  public GameController gameController;
  public bool isHealth;

  void Start ()
  {
    GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
    if (gameControllerObject != null)
    {
      gameController = gameControllerObject.GetComponent <GameController>();
    }
    if (gameController == null)
    {
      Debug.Log ("Cannot find 'GameController' script");
    }
  }

  void OnTriggerEnter (Collider other){
    if (other.tag == "Player")
    {
      if(isHealth)
        gameController.RestoreHealth(34,other.gameObject.GetComponent<PlayerController>());
      else
        gameController.GiveWeapon(other.gameObject.GetComponent<PlayerController>());
      
      Destroy(gameObject);

    }
  }

}
