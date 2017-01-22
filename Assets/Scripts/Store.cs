using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour {

	int _wavesLeft = 7;
	public int wavesLeft {
		get {
			return _wavesLeft;
		}
		set {
			if (_wavesLeft > 0) {
				_wavesLeft = value;
				RenderWavesLeft ();
			}
		}
	}

	public GameObject textGameObj;
	Text text;

	// Use this for initialization
	void Start () {
		text = textGameObj.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void RenderWavesLeft() {
		if (wavesLeft > 0) {
			text.text = wavesLeft.ToString () + " Waves Left";
		} else {
			text.text = "";
		}
	}
}
