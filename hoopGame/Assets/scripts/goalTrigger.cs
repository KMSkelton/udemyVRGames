using UnityEngine;
using System.Collections;

public class goalTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		secondTrigger trigger = GetComponentInChildren<secondTrigger>();
		trigger.expectCollider(other);
	}
}
