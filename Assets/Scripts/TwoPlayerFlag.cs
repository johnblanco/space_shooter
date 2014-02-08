using UnityEngine;
using System.Collections;

public class TwoPlayerFlag : MonoBehaviour {
  public bool twoPlayerGame;

  void Awake() {
    DontDestroyOnLoad(transform.gameObject);
  }
}
