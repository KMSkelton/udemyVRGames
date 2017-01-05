using UnityEngine;
using System.Collections;

public class scoreKeeper : MonoBehaviour {
	public int score = 0;

	void OnCollisionEnter(Collision collision) {
		print ("Ball hit target");
		score += 1;
		print("Score = " + score);
	}
}
