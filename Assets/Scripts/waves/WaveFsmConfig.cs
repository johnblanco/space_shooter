
using System;
using UnityEngine;
using HutongGames.PlayMaker;

public class WaveFsmConfig : MonoBehaviour
{
  
  public int objectsCount;
  public float warmingTime;
  public float waitBetweenObjects;
  
  
  public void Start()
  {
    GetComponent<PlayMakerFSM>().FsmVariables.GetFsmInt("objectsCount").Value = this.objectsCount;
    GetComponent<PlayMakerFSM>().FsmVariables.GetFsmFloat("waitBetweenObjects").Value = this.waitBetweenObjects;
    GetComponent<PlayMakerFSM>().FsmVariables.GetFsmFloat("warmingTime").Value = this.warmingTime;
    GetComponent<PlayMakerFSM>().SendRemoteFsmEvent("wave_ready");
  }
}


