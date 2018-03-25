using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerMushroomUp : MonoBehaviour {


    public GameObject outsideBox ;
    public GameObject insideBox;
    public float speed = .1f;
    public Vector3 pos;

private  void  Update()
    {

        transform.Translate(Vector3.up*speed*Time.deltaTime);
       
        outsideBox.SetActive(true);
        insideBox.SetActive(false);
    }

    
}
