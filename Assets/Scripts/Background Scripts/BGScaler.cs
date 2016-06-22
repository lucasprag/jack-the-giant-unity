using UnityEngine;
using System.Collections;

public class BGScaler : MonoBehaviour {

	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Vector3 tempScale = transform.localScale;

		float width = sr.sprite.bounds.size.x;

		float worldHeight = Camera.main.orthographicSize * 2f;
		float worldWidth = worldHeight / Screen.height * Screen.width;

		tempScale.x = worldWidth / width;

		transform.localScale = tempScale;
	}

	void Update () {
	
	}
}
