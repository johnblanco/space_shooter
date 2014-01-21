using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public EnergyBar energyBar;
  // Use this for initialization
	void Start () {
	}

  void Update(){
    if(Input.GetKeyUp(KeyCode.Space)){
      energyBar.health -= 10;
    }
  }

}
