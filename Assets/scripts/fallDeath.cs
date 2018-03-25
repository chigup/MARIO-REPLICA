using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fallDeath : MonoBehaviour {

    public AudioSource deathClip;
    public GameObject player;
   

    IEnumerator OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            player.SetActive(false);
            lives.totalLives--;
            deathClip.Play();
            yield return new WaitForSeconds(3);
            Application.LoadLevel(0);
           
            
        }

    }




}
