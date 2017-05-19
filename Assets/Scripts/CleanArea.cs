using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	bool foundClearArea = false;

	void Update () {
		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea) {
			SendMessageUpwards ("OnFindClearArea");
			foundClearArea = true;
		}
	}

	void OnTriggerStay (Collider other) {

		if (other.tag != "Player") {
			timeSinceLastTrigger = 0f;
		}
	}
}
