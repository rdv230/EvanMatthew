using UnityEngine;
using System.Collections;

public class basketball : MonoBehaviour {

	public AudioClip boink;
	public AudioSource myAudio;
	public int score;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision collider){
		//What we want to do next is make it so that the velocity of the basketball is tied to the sound
		myAudio.PlayOneShot(boink);
		score++;
		Debug.Log (score);

	}

}
