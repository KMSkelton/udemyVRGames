using UnityEngine;
using System.Collections;

public class goHomeGame: MonoBehaviour {

	Vector2 playerLocation; 
	Vector2 homeLocation;
	Vector2 pathToHome;
	bool gameIsOver = false;

	// Use this for initialization
	void Start () {
		playerLocation = new Vector2(2.5f, 3.0f); // distance in meters to home
		homeLocation = new Vector2(2.1f, 7.3f);
		pathToHome = playerLocation - homeLocation; 
		string instructions;
		print ("You are " + pathToHome.magnitude + " meters from home.");
		}
	void CalcDist(float x, float y) {
		if (!gameIsOver) {
			playerLocation = playerLocation + new Vector2 (x, y);
			print ("Location is: " + playerLocation + ". You are " + pathToHome.magnitude + " meters from home.");

			if (pathToHome.magnitude <= 0.15) {
				print ("You're home!");
				gameIsOver = true;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		pathToHome = playerLocation - homeLocation;

		if (Input.GetKeyDown (KeyCode.LeftArrow)) { 
			CalcDist (-0.1f, 0.0f);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) { 
			CalcDist (0.1f, 0.0f);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) { 
			CalcDist (0.0f, 0.1f);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) { 
			CalcDist (0.0f, -0.1f);
		}
	}

}