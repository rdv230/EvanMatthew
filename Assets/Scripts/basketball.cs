using UnityEngine;
using System.Collections;

public class basketball : MonoBehaviour {

	public AudioClip boink;
	public AudioSource myAudio;
	public static int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnCollisionEnter(Collision collider){
		//What we want to do next is make it so that the velocity of the basketball is tied to the sound
		float bBallVolume = GetComponent<Rigidbody>().velocity.magnitude/40;
		//Debug.Log ("bBallVolume: " + bBallVolume);
		myAudio.PlayOneShot(boink, bBallVolume);
	
		if(collider.gameObject.tag == "head"){
			score++;
			Debug.Log ("score: " + score);
		} 
		//else if (collider.gameObject.tag == "curry"){
		//	Debug.Log ("Haha, you missed my head!");
		//}

	}

		//		if(collider.gameObject.name == "rim"){
//					score++;
//				}

}
