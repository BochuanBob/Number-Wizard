using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;
    public Text text; 

    int maxGuessesAllowed = 10;

	// Use this for initialization
	void Start () {
        StartGame();
	}
	
    void StartGame()
    {
        max = 1001;
        min = 1;
        guess = 500;
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

    public void NextGuess()
    {
        guess = Random.Range(min,max+1);
        text.text = guess+"";

        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }

    
	// Update is called once per frame
	void Update () {
	
	}
}
