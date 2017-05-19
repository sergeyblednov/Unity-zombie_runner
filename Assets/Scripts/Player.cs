using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public Transform playerSpawnPoints;
	public Helicopter helicopter;
	public AudioClip whatHappened;

	private bool reSpawn = false;
	private Transform[] spawnPoints;
	private bool lastToggle = false;
	private AudioSource innerVoice;

	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
		AudioSource[] audioSources = GetComponents<AudioSource> ();
		foreach (AudioSource audioSource in audioSources) {
			if (audioSource.priority == 1) {
				innerVoice = audioSource;
			}
		}

		innerVoice.clip = whatHappened;
		innerVoice.Play ();
	}

	void Update () {
		if (lastToggle != reSpawn) {
			ReSpawn ();
		} else {
			lastToggle = reSpawn;
		}
	}

	void ReSpawn () {
		reSpawn = false;
		transform.position = spawnPoints[Random.Range (0, spawnPoints.Length)].position;

	}

	void OnFindClearArea () {
		Debug.Log ("Found clear area in a player");
		helicopter.Call ();
	}
}
