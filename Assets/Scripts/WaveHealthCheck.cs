using UnityEngine;
using System.Collections;

public class WaveHealthCheck : MonoBehaviour {
  int previousAmount = 0;

  void checkWaveHealth(){
    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

    if(previousAmount > 0 && enemies.Length == 0){
      GetComponent<PlayMakerFSM>().SendRemoteFsmEvent("new wave needed");
    }
    previousAmount = enemies.Length;
  }

}
