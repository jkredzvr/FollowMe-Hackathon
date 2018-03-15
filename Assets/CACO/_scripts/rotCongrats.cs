using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotCongrats : MonoBehaviour {

	public float speed = 1f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward, speed * Time.deltaTime);
		
	}
}
