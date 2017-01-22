using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Rigidbody2D body;
	bool facingRight = true;
	bool grounded = true;
	public LayerMask killer;
	public LayerMask ground;
	public GameObject gameObjStore;
	Store store;
	Animator animator;

	void Start () {
		body = this.GetComponent<Rigidbody2D> ();
		store = gameObjStore.GetComponent<Store> ();
		animator = GetComponent<Animator> ();
	}

	void Update () {
		var hor = Input.GetAxis ("Horizontal");

		body.velocity = new Vector2 (hor * 4f, body.velocity.y);

		if (hor > 0) {
			facingRight = true;
			animator.SetBool ("walking", true);
		} else if (hor < 0) {
			facingRight = false;
			animator.SetBool ("walking", true);
		} else if (hor == 0) {
			animator.SetBool ("walking", false);
		}

		transform.localScale = new Vector2 (facingRight ? 0.7f : -0.7f, transform.localScale.y);

		if (Physics2D.OverlapCircle (body.position, 1f, ground)) {
			grounded = true;
			animator.SetBool ("hurt", false);
		}

		if (Input.GetButtonDown ("Jump") && grounded) {
			body.velocity = new Vector2 (body.velocity.x, 9f);
			grounded = false;
		}

		if (Physics2D.OverlapCircle (body.position, 0.8f, killer)) {
			body.velocity = new Vector2 (body.velocity.x, 20f);
			store.wavesLeft = 7;
			animator.SetBool ("hurt", true);
		}

	}
}
