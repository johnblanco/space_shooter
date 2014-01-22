using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
<<<<<<< HEAD:Assets/Done/Done_Scripts/Done_Mover.cs
		print (this.tag);
		rigidbody.velocity = transform.forward * speed;
=======
    rigidbody.velocity = transform.forward * speed;
>>>>>>> refs/heads/feature/no_mas_done:Assets/Scripts/Mover.cs
	}

}
