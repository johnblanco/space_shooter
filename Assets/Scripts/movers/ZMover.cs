using UnityEngine;
using System.Collections;

public class ZMover : Mover
{
  public float speed;

  void Start()
  {
    rigidbody.velocity = transform.forward * speed;
  }

}
