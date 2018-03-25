using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDown : MonoBehaviour {

    public bool stoodOn;
    public GameObject pipe;
    public GameObject player;
    public GameObject fadeScreen;

    private void OnTriggerEnter(Collider other)
    {
        stoodOn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        stoodOn = false;
    }

    private void Update()
    {
        if (stoodOn && Input.GetButtonDown("GoDown"))
        {
        
            transform.position = new Vector3(0, -1000, 0);
           StartCoroutine(WaitingForPipe());

        }

    }

    private IEnumerator WaitingForPipe()
    {
        pipe.GetComponent<Animator>().enabled = true;
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(2);
        pipe.GetComponent<Animator>().enabled = false;
        fadeScreen.GetComponent<Animator>().enabled = false;
        Application.LoadLevel(1);
    }
}
