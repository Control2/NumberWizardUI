using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard2 : MonoBehaviour
{

    // Use this for initialization
    int max;
    int min = 1;
    private int guess;
    private int maxGuessesAllowed = 10;

    public Text text;
    public Text maxGuess;

    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000000;
        min = 0;
        guess = Random.Range(min, max);

        max += 1;

    }

    void StartGame2()
    {
        print("========================");
        print("Press KeyPad Period to start the game over");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GuessHigher();
            print("Higher Or Lower Than " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GuessLower();
            print("Higher Or Lower Than " + guess);
        }
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        text.text = guess.ToString();
        if (maxGuessesAllowed <= 0)
        Application.LoadLevel("Win");
        maxGuessesAllowed--;
        maxGuess.text = maxGuessesAllowed.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        }
    }
}
