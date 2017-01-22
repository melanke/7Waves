using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceToPlay : MonoBehaviour {
	
	void Start () {
		
	}

	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			SceneManager.LoadScene("Game");
		}
	}
}
