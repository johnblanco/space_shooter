using UnityEngine;
using System.Collections;

public class EnemyLoot : MonoBehaviour {

  public bool hasHealthBox;
  public bool weaponBox;

	// Use this for initialization
	void Start () {
    hasHealthBox = Random.Range(0,5) == 0;
    weaponBox = Random.Range(0,5) == 0;
	}
}
