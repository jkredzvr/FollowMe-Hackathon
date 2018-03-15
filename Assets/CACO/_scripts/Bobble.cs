using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobble : MonoBehaviour {

	public float amplitude;
	public float speed;
	public float tempVal;
	public Vector3 tempPos;
	public Quaternion rotSpeed;

	public bool playBobble = true;


	// Use this for initialization
	void Start () {

		tempVal = transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {

		if (playBobble) {
			tempPos.y = tempVal + amplitude * Mathf.Sin (speed * Time.time);
			transform.position = new Vector3(tempPos.x, tempPos.y, tempPos.z);
		}
	}
}
