using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 30f;
	Rigidbody rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate(){


		float moveLeft = Input.GetAxis ("Horizontal");
		float moveUp = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveLeft,0.0f,moveUp);

		rb.AddForce (movement*speed);

	}

}
