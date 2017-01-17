using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeDisplay : MonoBehaviour {

	levelManager timeDisplayed;
	Text timeText;

	// Use this for initialization
	void Start () {
		timeText = GetComponent<Text> ();
		timeDisplayed = FindObjectOfType<levelManager>();
	}

	// Update is called once per frame
	void Update () {
		timeText.text = "Time Remaining: " + timeDisplayed.timeRemaining;
	}
}
