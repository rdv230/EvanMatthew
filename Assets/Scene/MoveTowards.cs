using UnityEngine;
using System.Collections;

public class MoveTowards : MonoBehaviour {

	Renderer myRenderer;
	bool isChangingPosition;

	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer>();
		isChangingPosition = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(myRenderer.isVisible){
			isChangingPosition = true;
			if(!myRenderer.isVisible){
				isChangingPosition = false;
				transform.position = new Vector3(transform.position.x + Camera.main.pixelWidth, transform.position.y, transform.position.z); 
			}
		}


	}
}
