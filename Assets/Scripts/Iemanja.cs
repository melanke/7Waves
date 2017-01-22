using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iemanja : MonoBehaviour {
	
	public GameObject gameObjStore;
	Store store;
	bool awake = false;
	Animator animator;
	public GameObject chicken, candles, cat;

	void Start () {
		store = gameObjStore.GetComponent<Store> ();
		animator = GetComponent<Animator> ();
	}

	void Update () {
		if (store.wavesLeft <= 0 && !awake) {
			awake = true;
			animator.SetBool ("awake", true);
		}
	}

	void ThrowOfferings() {
		cat.GetComponent<Throwable> ().BeingThrow = true;
		chicken.GetComponent<Throwable> ().BeingThrow = true;
		candles.GetComponent<Throwable> ().BeingThrow = true;

		StartCoroutine(End ());
	}

	IEnumerator End()
	{
		yield return new WaitForSeconds(4);

		SceneManager.LoadScene ("End");
	}
}
