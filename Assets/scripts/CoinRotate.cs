using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour {

	// Update is called once per frame
	public float angularVel;
	void Update () {
		gameObject.transform.Rotate (new Vector3(0, angularVel,  0));
	}
}
