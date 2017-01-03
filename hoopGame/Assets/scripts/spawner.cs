using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public GameObject basketBall;
	public GameObject bowlingBall;

	// Use this for initialization
	void Start () {
	}

	void makeBall(int x, int y, int z, string ballType = "basketBall") {
		GameObject instance;
		if (ballType == "bowlingBall") {
			instance = Instantiate (bowlingBall);
		}
			else {
			instance = Instantiate (basketBall);
		}

		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		rb.velocity = new Vector3(x, y, z);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) ) {
			makeBall(5,-2,0,"bowlingBall");
		}
		if (Input.GetKeyDown (KeyCode.UpArrow) ) {
			makeBall(10,0,0);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow) ) {
			makeBall(-10,0,0);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) ) {
			makeBall(0,0,10);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) ) {
			makeBall(0,0,-10);
		}

	}
}
