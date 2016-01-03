using UnityEngine;
using System.Collections;

public class NumberW : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
		Debug.Log ("Welcome to Number Wizard");
		Debug.Log ("Pick a number in your head, but don't tell me!");

		Debug.Log ("The highest number you can pick is " + max);
		Debug.Log ("The lowest number you can pick is " + min);

		Debug.Log ("Is the number higher or lower than " + guess + "?");
		Debug.Log ("Up = higher, down = lower, return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) { // Up arrow key pressed
			//Debug.Log ("Up arrow pressed");

			min = guess;
			guess = (max + min) / 2;

			Debug.Log ("Higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) { // Down arrow key pressed
			//Debug.Log ("Down arrow pressed");

			max = guess;
			guess = (max + min) / 2;

			Debug.Log ("Higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown (KeyCode.Return)) { // Enter key pressed
			//Debug.Log ("Enter pressed");

			Debug.Log ("Your number is " + guess + "!!");
		}
	}
}
