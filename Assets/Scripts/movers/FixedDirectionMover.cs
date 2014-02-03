using UnityEngine;
using System.Collections;

public class FixedDirectionMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	

	void FixedUpdate () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player != null) {
			// direccion hacia el player
			Vector3 directionToPlayer = player.transform.position - transform.position;

			transform.forward = - directionToPlayer;
		}
	}
}
