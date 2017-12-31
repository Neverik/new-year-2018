using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour {
	
	void OnCollisionEnter2D (Collision2D col) {
		if (col.collider.tag == "Finish") {
			Destroy (gameObject);
		}
	}
}
