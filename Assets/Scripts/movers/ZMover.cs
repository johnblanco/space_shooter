using UnityEngine;
using System.Collections;

public class ZMover : MonoBehaviour
{
  public float speed;

  void Start()
  {
    rigidbody.velocity = transform.forward * speed;
  }

}
