using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	public int currentIndex;
	// Use this for initialization
	void Start () {

		currentIndex = SceneManager.GetActiveScene ().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) ) {
			SceneManager.LoadScene(currentIndex +1);
		}

	}
}


// Instructor's method: 
// void Update () {
// if (Input.GetKeyDown (KeyCode.Space) ) { 
// LoadNextScene();
// 	  } 
//  }
// void LoadNextScene () {
// int currentIndex = SceneManager.GetActiveScene().buildIndex;
// SceneManager.LoadScene(currentIndex +1)
// }
