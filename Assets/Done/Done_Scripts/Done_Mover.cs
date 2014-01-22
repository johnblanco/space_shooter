using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		print (this.tag);
		rigidbody.velocity = transform.forward * speed;
	}
}
