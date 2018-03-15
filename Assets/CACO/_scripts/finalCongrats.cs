using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalCongrats : MonoBehaviour {

	public bool endReached = false;
	public GameObject congratsOBJ;
		
	// Update is called once per frame
	void Update () {
		if (endReached) {
			congratsOBJ.SetActive (true);
		}
	}


}
