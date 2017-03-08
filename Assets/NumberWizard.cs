using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	int guessCounter;
	int maxGuessesAllowed;
	
	public Text text;

	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guessCounter = 1;
		maxGuessesAllowed = 10;
		NextGuess ();
	}
	
	public void GuessHigher () {
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower () {
		max = guess;
		NextGuess ();
	}

	void NextGuess () {
		guess = Random.Range (min, max + 1);
		guessCounter = guessCounter + 1;
		if (guessCounter > maxGuessesAllowed) {
			Application.LoadLevel ("Win");
		}
		text.text = "Is your number higher, lower or exactly " + guess.ToString () + "?";
	}
}
