using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	private float speed = 1f;
	private float acceleration = 0.2f;
	private float maxSpeed = 3.2f;

	private float easySpeed = 3.4f;
	private float mediumSpeed = 3.9f;
	private float hardSpeed = 4.5f;

	[HideInInspector]
	public bool moveCamera;

	void Start () {

		if (GamePreferences.GetEasyDifficulty () == 1) {
			maxSpeed = easySpeed;
		}

		if (GamePreferences.GetMediumDifficulty () == 1) {
			maxSpeed = mediumSpeed;
		}

		if (GamePreferences.GetHardDifficulty () == 1) {
			maxSpeed = hardSpeed;
		}

		moveCamera = true;
	}

	void Update () {
		if (moveCamera) {
			MoveCamera ();
		}
	}

	void MoveCamera () {
		Vector3 temp = transform.position;
		float oldY = temp.y;
		float newY = temp.y - (speed * Time.deltaTime);
		temp.y = Mathf.Clamp (temp.y, oldY, newY);
		transform.position = temp;

		speed += acceleration * Time.deltaTime;

		if (speed > maxSpeed) {
			speed = maxSpeed;
		}
	}
}
