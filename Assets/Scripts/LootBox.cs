using UnityEngine;
using System.Collections;

public class LootBox : MonoBehaviour {

  public GameController gameController;
  public bool isHealth;

  void OnTriggerEnter (Collider other){
    if (other.tag == "Player")
    {
      //FIXME: esta saltando null reference exception, creo que podria inicializar el gameController desde el destroyByContact
      // que fue el que spawneo la caja
      if(isHealth)
        gameController.RestoreHealth(34);
      else
        gameController.GiveWeapon();
      
      Destroy(gameObject);

    }
  }

}
