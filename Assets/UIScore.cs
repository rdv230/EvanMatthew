using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScore : MonoBehaviour {

	Text myText;
	
	void Awake(){
		if(Application.loadedLevel == 0){
			basketball.score = 0;
		}
	}

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		myText.text = "Score: " + basketball.score;
		

	}
}
