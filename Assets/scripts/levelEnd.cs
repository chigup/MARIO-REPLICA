using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelEnd : MonoBehaviour
{

    public GameObject player;
    public float End = -2.093f;

    public Text winText;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<GameObject>();
        winText = GetComponent<Text>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
         
            winText.text = "YOU WIN!!!";
            player.transform.Translate(0, 0, End);


        }


    }
}
