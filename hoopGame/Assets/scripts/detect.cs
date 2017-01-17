using UnityEngine;
using System.Collections;


public class detect : MonoBehaviour {
	public int scorePerHit = 1;

	void OnCollisionEnter(Collision collision){
		scoreKeeper scoreKeep = FindObjectOfType<scoreKeeper>();
		scoreKeep.IncrementScore(scorePerHit);
	}
}
