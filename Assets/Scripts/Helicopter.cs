using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound;

	private bool called = false;
	Rigidbody rigitbody;
	AudioSource source;

	void Start () {
		AudioSource source = GetComponent<AudioSource> ();
		rigitbody = GetComponent<Rigidbody> ();
	}

	public void Call () {
		if (!called) {
			called = true;
			print ("Helicopter called");
			source = GetComponent<AudioSource> ();
			source.clip = callSound;
			source.Play ();
			rigitbody.velocity = new Vector3 (0, 0, 50f);
		}
	}
}
