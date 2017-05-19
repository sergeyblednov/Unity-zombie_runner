using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	private bool called = false;
	Rigidbody rigitbody;

	void Start () {
		rigitbody = GetComponent<Rigidbody> ();
	}

	void OnDispatchHelicopter () {
		print ("Helicopter called");
		rigitbody.velocity = new Vector3 (0, 0, 50f);
		called = true;
	}
}
