using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallMarioBlockInteraction : MonoBehaviour {
	public float jump;
	IEnumerator OnTriggerEnter(Collider c){
		gameObject.GetComponent<Collider> ().isTrigger = false;
		if (c.tag=="Player") {
			this.transform.position = new Vector3 (transform.position.x, (transform.position.y) + jump, transform.position.z);
			yield return new WaitForSeconds (0.08f);
			this.transform.position = new Vector3 (transform.position.x, (transform.position.y) - jump, transform.position.z);
			yield return new WaitForSeconds (0.2f);
			gameObject.GetComponent<Collider> ().isTrigger = true;
		}
	}
}
