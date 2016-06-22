using UnityEngine;
using System.Collections;

public class PlayerBounds : MonoBehaviour {

	private float minX, maxX;

	void Start () {
		SetMinAndMaxX ();
	
	}

	void Update () {

		if (transform.position.x < minX) {
			Vector3 temp = transform.position;
			temp.x = minX;
			transform.position = temp;
		}

		if (transform.position.x > maxX) {
			Vector3 temp = transform.position;
			temp.x = maxX;
			transform.position = temp;
		}
	
	}

	void SetMinAndMaxX() {
		Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0));

		maxX = bounds.x;
		minX = -bounds.x;
	}
}
