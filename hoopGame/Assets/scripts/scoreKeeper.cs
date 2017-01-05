using UnityEngine;
using System.Collections;

public class scoreKeeper : MonoBehaviour {
	public int score = 0;

	public void IncrementScore(int amount) 
	{
		print ("Ball hit target");
		score += amount;
		print("Score = " + score);
	}
}
