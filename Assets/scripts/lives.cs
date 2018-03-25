
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{

   public static int totalLives;
    private Text textBox;
    private int inLives;


    private void Start()
    {
        textBox = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        inLives = totalLives;
        textBox.text =      "LIVES: "+inLives ;

        if (inLives == 0)
        {
            gameOverScene();
        }

    }

    private void gameOverScene()
    {
        totalLives += 3;
        Application.LoadLevel(3);
    }
}
