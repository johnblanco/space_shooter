using UnityEngine;
using System.Collections;

public class HitPlayerHeavy : MonoBehaviour {
  private GameController gameController;
  public GameObject explosion;

	// Use this for initialization
	void Start () {
    GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
    if (gameControllerObject != null)
    {
      gameController = gameControllerObject.GetComponent <GameController>();
    }
	}

  void OnTriggerEnter(Collider other){
    if (other.tag == "Player"){
      Instantiate(explosion, transform.position, transform.rotation);
      gameController.HitPlayer(34, other.gameObject.GetComponent<PlayerController>());
    }
  }
}
