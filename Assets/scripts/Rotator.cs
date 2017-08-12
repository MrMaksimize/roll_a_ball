using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	private float time = 0.0f;
	public float interpolationPeriod = 0.1f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		time += Time.deltaTime;
		if (time >= interpolationPeriod) {
			time = 0.0f;
			GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
		}
	}
}
