using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints;
	public bool reSpawn = false;

	private Transform[] spawnPoints;
	private bool lastToggle = false;

	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
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
}
