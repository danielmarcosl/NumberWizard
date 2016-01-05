using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class NumberW : MonoBehaviour {

	int max;
	int min;
	int guess;

	int maxGuessesAllowed = 10;

	public Text text;

	// Use this for initialization
	void Start () {
		InitiliceVariables ();
		ShowInitialDebugLog ();
	}

	void ShowInitialDebugLog () {
		Debug.Log ("========================");
		Debug.Log ("Welcome to Number Wizard");
		Debug.Log ("Pick a number in your head, but don't tell me!");

		Debug.Log ("The highest number you can pick is " + max);
		Debug.Log ("The lowest number you can pick is " + min);

		Debug.Log ("Is the number higher or lower than " + guess + "?");
		Debug.Log ("Up = higher, down = lower, return = equal");

		//text.text = "Welcome to Number Wizard\n" +
		//	"Pick a number in your head, but don't tell me!\n" +
		//	"The highest number you can pick is " + max + "\n" +
		//	"The lowest number you can pick is " + min + "\n" +
		//	"Is the number higher or lower than " + guess + "?\n" +
		//	"Up = higher, down = lower, return = equal";

		max += 1; // Prevent that the number 1000 won't be displayed
	}

	void InitiliceVariables () {
		max = 1000;
		min = 1;
		guess = 500;
	}

	public void GuessLower () {
		max = guess;
		NextGuess ();
	}

	public void GuessHigher () {
		min = guess;
		NextGuess ();
	}

	void NextGuess () {
		guess = (max + min) / 2;
		maxGuessesAllowed -= 1;

		text.text = guess.ToString ();

			//"Higher or lower than " + guess + "?\n" +
			//"Up = higher, down = lower, return = equal";

		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene ("Win");
		}

		Debug.Log ("Higher or lower than " + guess + "?");
		Debug.Log ("Up = higher, down = lower, return = equal");
	}
}
