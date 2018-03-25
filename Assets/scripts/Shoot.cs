using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public int speed;
    public AudioSource fireball;


    private void Start()
    {
        fireball = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void  Update () {
        if (Input.GetKeyDown(KeyCode.J)) {
          
          StartCoroutine(  Fire());
        }
	}

    IEnumerator Fire() {

        fireball.Play();
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        yield return new WaitForSeconds(.4f);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
        Destroy(bullet, .50f);
    }

  
}
