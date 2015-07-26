using UnityEngine;
using System.Collections;

public class GameOverSoundandRestart : MonoBehaviour {

	public AudioClip EndSound;
	public AudioSource myAudioSource;

	// Use this for initialization
	void Start () {
		//Invoke ("PlaySound");
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel (0);
		}
	
	}

	//void PlaySound(){
	//	Debug.Log ("Play");
	//	myAudioSource.PlayOneShot(EndSound);
	//}
}
