using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour {

	public Transform[] emitters;
	public GameObject toEmit;
	public float delay;

	void Start () {
		StartCoroutine ("Emit");
	}

	IEnumerator Emit() {
		while (true) {
			yield return new WaitForSeconds (delay);
			int i = Random.Range (0, emitters.Length);
			Transform whereToSpawn = emitters [i];
			Instantiate (toEmit, whereToSpawn.position, Quaternion.Euler (new Vector3 (0f, 0f, Random.Range (0f, 180f))));
		}
	}
}
