using UnityEngine;
using System.Collections;

public class scoreAbsorber : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;

		scoreKeeper previousScore = FindObjectOfType<scoreKeeper> ();
		if (previousScore) {
			score = previousScore.score;
			Destroy (previousScore.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
