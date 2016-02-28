using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	private int m_max = 100;
	private int m_min = 1;
	private int m_guess = 50;
	public Text numberText;
	int maxGuessesAlowed = 7;
	//-----------------------------------------------------------------------------------
	// Use this for initialization
	void Start () 
	{
		StartGame();
	}
	//-----------------------------------------------------------------------------------
	//Initialization of the game
	void StartGame()
	{
		m_max = 100;
		m_min = 1;
		NextGuess();
	}
	//-----------------------------------------------------------------------------------
	// This method deals with the next guess, using the feedback comming from the user
	void NextGuess()
	{
		int newGuess = Random.Range(m_min, m_max+1);
		//If we are guessing a number similar to the last one, try to guess again
		if(newGuess == m_guess)
		{
			newGuess = Random.Range(m_min, m_max+1);
		}		

		m_guess = newGuess;
		//Show new guess and update game state
		numberText.text = m_guess.ToString();
		maxGuessesAlowed = maxGuessesAlowed - 1;
		if(maxGuessesAlowed < 0)
		{
			Application.LoadLevel("Win");
		}
	}
	//-----------------------------------------------------------------------------------
	// Guess a higher number
	public void guessHigher()
	{
		m_min = m_guess;
		NextGuess();
	}
	//-----------------------------------------------------------------------------------
	// Guess a lower number
	public void guessLower()
	{
		m_max = m_guess;
		NextGuess();
	}
}
