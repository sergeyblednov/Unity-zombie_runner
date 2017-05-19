using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints;
	public GameObject landingAreaPrefab;

	private bool reSpawn = false;
	private Transform[] spawnPoints;
	private bool lastRespawnToggle = false;

	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
	}

	void Update () {
		if (lastRespawnToggle != reSpawn) {
			ReSpawn ();
		} else {
			lastRespawnToggle = reSpawn;
		}
	}

	void ReSpawn () {
		reSpawn = false;
		int i = Random.Range (0, spawnPoints.Length);
		transform.position = spawnPoints[i].position;

	}

	void OnFindClearArea () {
		Invoke ("DropFlare", 3f);
	}

	void DropFlare () {
		print ("Dropped the flare");
		Instantiate (landingAreaPrefab, transform.position, transform.rotation);
	}
}
