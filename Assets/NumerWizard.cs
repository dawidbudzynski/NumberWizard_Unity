using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerWizard : MonoBehaviour
{
    int max_num = 1000;
    int min_num = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max_num = 1000;
        min_num = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick number between " + min_num + " and " + max_num);
        Debug.Log("Is your number" + guess + "?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max_num = max_num + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min_num = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max_num = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("So your number is: " + guess + "?");
            Debug.Log("Thanks for playing!");
            Debug.Log("*************************************");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (min_num + max_num) / 2;
        Debug.Log("Is your number" + guess + "?");
    }
}
