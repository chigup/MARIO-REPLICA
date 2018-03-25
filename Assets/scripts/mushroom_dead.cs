using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom_dead : MonoBehaviour {


    public GameObject mushroom;
    public float flatness = .1f;
    public AudioSource squish;



    private IEnumerator OnTriggerEnter(Collider other)
    {
        
        
            squish.Play();
            mushroom.GetComponent<enemy_movement>().enabled = false;  
            mushroom.transform.localScale -= new Vector3(0, flatness, 0);
            mushroom.SetActive(false);
            yield return new WaitForSeconds(1);
            mushroom.transform.position = new Vector3(0, -300, 0);
        
      

    }
    






}
