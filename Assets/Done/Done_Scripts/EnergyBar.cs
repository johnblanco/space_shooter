using UnityEngine;
using System.Collections;

public class EnergyBar : MonoBehaviour {

  public GUITexture full;
  
  void Start () {
    
	}
	
	void Update () {
	  if(Input.GetKeyUp(KeyCode.Space)){
      full.enabled = !full.enabled;
    }
	}


  IEnumerator Half(){
    yield return new WaitForSeconds(3);

  }
}
