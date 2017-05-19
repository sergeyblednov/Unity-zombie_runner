using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

	public AudioClip initialHeliCall;
	public AudioClip initialCallReply;

	AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	void OnMakeInitialHeliCall () {
		audioSource.clip = initialHeliCall;
		audioSource.Play ();
		Invoke ("OnMakeInitialCallReply", initialHeliCall.length + 1f);
	}

	void OnMakeInitialCallReply () {
		audioSource.clip = initialCallReply;
		audioSource.Play ();
		BroadcastMessage ("OnDispatchHelicopter");
	}
}
