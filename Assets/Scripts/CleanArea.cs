using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	void Update () {
		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f) {
			SendMessageUpwards ("OnFindClearArea");
		}
	}

	void OnTriggerStay (Collider other) {

		if (other.gameObject.name == "Player") {
			return;
		}

		timeSinceLastTrigger = 0f;
	}
}
