using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max_num;
    [SerializeField] int min_num;
    [SerializeField] int guess;
    [SerializeField] TextMeshProUGUI guessText;

    void Start()
    {
        if (guessText)
        {
            NextGuess();
        }
    }

    public void OnPressHigher()
    {
        min_num = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max_num = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min_num, max_num + 1);
        guessText.text = "Is your number: " + guess.ToString() + "?";
    }
}
