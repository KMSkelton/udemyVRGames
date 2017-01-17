using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour {

	scoreKeeper scoreDisplayed;
	Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
		scoreDisplayed = FindObjectOfType<scoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + scoreDisplayed.score;
	}
}
