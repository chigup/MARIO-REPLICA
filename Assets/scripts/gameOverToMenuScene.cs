using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverToMenuScene : MonoBehaviour {


    private IEnumerator Start()
    {

      yield return new   WaitForSeconds(3);
        Application.LoadLevel(4);

    }
}
