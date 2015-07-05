using UnityEngine;
using System.Collections;

public class Pickupball : MonoBehaviour {

	Transform myTransform;
	public Transform handTransform;
	public bool isHolding;
	public Transform ball;
	public Rigidbody ballBody;


	// Use this for initialization
	void Start () {
		myTransform = transform;
		isHolding = false;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 handPos = handTransform.position;

		//If you're not holding the ball and you press Q then you start holding the ball
		if(!isHolding && Input.GetKeyDown (KeyCode.Alpha1)){
			isHolding = true;
		}

		//If you're holding the ball, the ball loses mass and moves position towards your "hand"
		if(isHolding){
			ball.transform.position = handPos;
			ballBody.useGravity = false;
			ballBody.isKinematic = true;
			ballBody.mass = 0;


			//If you're holding the ball and then press Space, you drop the ball
			if(Input.GetKeyDown(KeyCode.Alpha2)){
				isHolding = false;
			}
		}

		//If you let go of the ball it gains mass and drops
		if(!isHolding){
			ballBody.mass = 1;
			ballBody.useGravity = true;
			ballBody.isKinematic = false;
		}

	}
}
