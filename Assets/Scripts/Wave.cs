using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Wave : MonoBehaviour {

	public LayerMask player;
	public Transform aboveWave;
	public GameObject textGameObject;
	public GameObject gameObjStore;
	Store store;
	static long LAST_WAVEJUMP_TICK = 0;
	
	void Start () {
		store = gameObjStore.GetComponent<Store> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transform.position.x - 0.1f, transform.position.y);

		if (transform.position.x <= -7) {
			transform.position = new Vector2 (20, transform.position.y);
		}

		if (transform.position.x > 1 && Physics2D.OverlapCircle (aboveWave.position, 2f, player) && LAST_WAVEJUMP_TICK < (DateTime.Now.Ticks - 10000000)) {
			LAST_WAVEJUMP_TICK = DateTime.Now.Ticks;
			store.wavesLeft--;
		}
	}
}
