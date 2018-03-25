using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour {

	public Text CoinDisplay;
	public static int score;


    private void Start()
    {
        CoinDisplay = GetComponent<Text>();
    }
    void Update(){
		CoinDisplay.text =   "Score : " + score;
        Debug.Log(score);
	}
}
