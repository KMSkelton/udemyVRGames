using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameOverScoreDisplay : MonoBehaviour {

	scoreAbsorber finalScoreDisplayed;
	Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
		finalScoreDisplayed = FindObjectOfType<scoreAbsorber>();
	}

	// Update is called once per frame
	void Update () {
		scoreText.text = "Final Score: " + finalScoreDisplayed.score;
	}
}
