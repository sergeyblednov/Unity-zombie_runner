using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour {

	[Tooltip ("Number of miinutes per econd thet pass, try 60")]
	public float minutesPerSeconds;

	void Update () {
		float anglePerFrame = Time.deltaTime / 360 * minutesPerSeconds;
		transform.RotateAround (transform.position, Vector3.forward, anglePerFrame);
	}
}
