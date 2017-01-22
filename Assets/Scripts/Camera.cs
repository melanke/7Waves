using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Camera : MonoBehaviour {

	float offset = 4f;
	public GameObject player;

	void Start () {
	}

	void LateUpdate () {
		float x = player.transform.position.x + offset;
		x = (float) Math.Min (x, 2.9f);
		x = (float) Math.Max (x, 1f);

		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}
}
