    
using UnityEngine;


public class CoinTake : MonoBehaviour {

    public AudioSource coinClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CoinScore.score += 1;
            Destroy(gameObject);
            coinClip.Play();
        }
    }

}
