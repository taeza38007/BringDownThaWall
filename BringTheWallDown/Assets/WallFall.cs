using UnityEngine;
using System.Collections;

public class WallFall : MonoBehaviour 
{
	
	private Vector3 Wallpos; 


	void Start () 
	{
		
	}
	

	void FixedUpdate ()
	{

		Vector3	Wallpos = transform.rotation.eulerAngles;

		if (Wallpos.x == 90f) {
			Destroy (this.gameObject);
		}
	}

}
