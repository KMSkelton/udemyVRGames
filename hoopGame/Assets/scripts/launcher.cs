using UnityEngine;
using System.Collections;

public class launcher : MonoBehaviour {

	public GameObject basketBall;
	public GameObject bowlingBall;
	public float ballSpeed = 0.1f;

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

		instance.transform.position = transform.position;
		Camera camera = GetComponentInChildren<Camera> ();
			
		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		rb.velocity = camera.transform.rotation * new Vector3(x, y, z) * ballSpeed;


	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.V)) {
			makeBall (0, 1, 5, "bowlingBall");
		}
		if (Input.GetButtonDown ("Fire1")) {
			makeBall (0, 0, 10);
		}
	}
}