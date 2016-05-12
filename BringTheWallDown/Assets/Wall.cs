using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	public FracturedObject fo;
	public bool StaticOrNot;

	void Start () {
	
	}
	

	void Update () {
	
		fo.StartStatic = StaticOrNot;

	}
}
