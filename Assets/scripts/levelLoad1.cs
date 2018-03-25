using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelLoad1 : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {

        yield return  new WaitForSeconds(3f); 
        Application.LoadLevel(3);
	}
	
	
}
