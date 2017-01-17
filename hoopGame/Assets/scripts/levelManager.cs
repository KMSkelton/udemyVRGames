using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	public float timeRemaining = 5.0f;

	public int currentIndex;
	// Use this for initialization
	void Start () {
	}
	 void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) { 
			LoadNextScene ();
		} 

		if (timeRemaining > 0) {
			
		timeRemaining -= Time.deltaTime;

			if (timeRemaining < 0) {
				LoadNextScene();
			}
		}
	}

	public void LoadNextScene() {
	 	int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void LoadPreviousScene() {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);
	}

}