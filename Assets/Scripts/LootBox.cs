using UnityEngine;
using System.Collections;

public class LootBox : MonoBehaviour {

  public GameController gameController;
  public bool isHealth;

  void OnTriggerEnter (Collider other){
    if (other.tag == "Player")
    {
      if(isHealth)
        gameController.RestoreHealth(34);
      else
        gameController.GiveWeapon();
      
      Destroy(gameObject);

    }
  }

}
