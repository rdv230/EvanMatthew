using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {


	float timePlayed;
	Text myText;

	// Use this for initialization
	void Awake () {
		timePlayed = 15;
	}

	void Start(){
		myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
		myText.text = "Timer: " + timePlayed;

		if (timePlayed > 0){
			timePlayed -= Time.deltaTime;

		} else{
			//We want the game to end and show the score, right

			Application.LoadLevel("GameOver");
		}


	}
}
