using UnityEngine;
using System.Collections;

public class LookAT : MonoBehaviour {

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
		//ADD THIS TO YOUR GAME!
		if(GameObject.Find("FPSController") != null){
			transform.LookAt(GameObject.Find("FPSController").transform);

	
		}

	}
}
