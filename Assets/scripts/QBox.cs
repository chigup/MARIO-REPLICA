using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBox : MonoBehaviour {

    public GameObject openBox;
    public GameObject closedBox;
    public GameObject mushroomInBox;
    public GameObject mushroomOutsideBox;

    private void Start()
    {
        
        mushroomOutsideBox.SetActive(false);
        mushroomInBox.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            closedBox.SetActive(false);
            openBox.SetActive(true);
            mushroomInBox.SetActive(true);
           
        }



    }







}
