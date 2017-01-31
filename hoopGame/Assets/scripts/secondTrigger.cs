using UnityEngine;
using System.Collections;

public class secondTrigger : MonoBehaviour {

	public int scorePerHit = 1;
	Collider expectedCollider;

	public void expectCollider(Collider collider) {
		expectedCollider = collider;
	}

	void OnTriggerEnter(Collider otherCollider) {
		if (otherCollider == expectedCollider) {
			scoreKeeper scoreKeep = FindObjectOfType<scoreKeeper>();
			scoreKeep.IncrementScore(scorePerHit);
			print ("Second trigger triggered");
		}
	}
		
}
