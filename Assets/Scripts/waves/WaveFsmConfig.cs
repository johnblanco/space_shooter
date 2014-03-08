
using System;
using UnityEngine;
using HutongGames.PlayMaker;

public class WaveFsmConfig : MonoBehaviour
{
  
  public int iterationCount;
  public float warmingTime;
  public float waitBetweenObjects;
  
  
  public void Start()
  {
    GetComponent<PlayMakerFSM>().FsmVariables.GetFsmInt("iterationCount").Value = this.iterationCount;
    GetComponent<PlayMakerFSM>().FsmVariables.GetFsmFloat("waitBetweenObjects").Value = this.waitBetweenObjects;
    GetComponent<PlayMakerFSM>().FsmVariables.GetFsmFloat("warmingTime").Value = this.warmingTime;
    GetComponent<PlayMakerFSM>().SendRemoteFsmEvent("wave_ready");
  }
}


