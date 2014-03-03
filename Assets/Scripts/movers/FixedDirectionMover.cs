using UnityEngine;
using System.Collections;

public class FixedDirectionMover : Mover
{

  // Use this for initialization
  void Start()
  {
    
  }

  void FixedUpdate()
  {
    GameObject player = GameObject.FindGameObjectWithTag("Player");
    if (player != null)
      {
        // direccion hacia el player
        Vector3 directionToPlayer = player.transform.position - transform.position;

        transform.forward = - directionToPlayer;
      }
  }
}
