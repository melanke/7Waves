using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour {

	public bool BeingThrow {
		set {
			GetComponent<Animator>().SetBool("BeingThrow", value);
		}
	}

	void Start () {

	}

	void Update () {

	}

	public void DestroyItself() {
		Destroy (gameObject);
	}
}
