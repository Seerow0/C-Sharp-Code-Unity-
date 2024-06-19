using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

	public float speed = 9000f;
	void Update () {
		transform.Rotate (Vector3.left, speed * Time.deltaTime);
	}
}
