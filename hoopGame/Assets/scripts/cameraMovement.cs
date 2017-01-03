using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		float rotationSpeed = 5.0f;
		float mouseY = Input.GetAxis ("Mouse Y"); // up and down
		float mouseX = Input.GetAxis ("Mouse X"); // left and right
		transform.localRotation *=  Quaternion.Euler (0, mouseX * rotationSpeed, 0);
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.localRotation *= Quaternion.Euler(mouseY * rotationSpeed, 0, 0);
	}
}
