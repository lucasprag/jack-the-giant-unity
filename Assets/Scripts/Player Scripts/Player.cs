using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 8f, maxVelocity = 4f;

	private Rigidbody2D myBody;
	private Animator anim;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Start () {
	
	}

	void FixedUpdate () {
		PlayerMoveKeyboard ();
	}

	void PlayerMoveKeyboard() {
		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);

		float h = Input.GetAxisRaw ("Horizontal");

		if (h > 0) { // going to the right
			if (vel < maxVelocity) {
				forceX = speed;
			}

			Vector3 tempScale = transform.localScale;
			tempScale.x = 1.3f;
			transform.localScale = tempScale;

			anim.SetBool ("Walk", true);
		} else if (h < 0) { // going to the left

			if (vel < maxVelocity) {
				forceX = -speed;
			}

			Vector3 tempScale = transform.localScale;
			tempScale.x = -1.3f;
			transform.localScale = tempScale;

			anim.SetBool ("Walk", true);

		} else {
			anim.SetBool ("Walk", false);
		}

		myBody.AddForce (new Vector2 (forceX, 0));
		
	}
}
