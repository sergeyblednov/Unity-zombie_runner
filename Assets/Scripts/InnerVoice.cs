﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

	public AudioClip whatHappend;
	public AudioClip goodLandingArea;

	AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = whatHappend;
		audioSource.Play ();
	}

	void OnFindClearArea () {
		print (name + "OnFindClearArea");
		audioSource.clip = goodLandingArea;
		audioSource.Play ();

		Invoke ("CallHeli", goodLandingArea.length + 1f);
	}
		
	void CallHeli () {
		SendMessageUpwards ("OnMakeInitialHeliCall");
	}
}