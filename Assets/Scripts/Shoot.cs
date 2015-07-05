using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public GameObject Ball;
	public float speed;
	public Vector3 heading;

	Vector3 cameraPos; 
	Vector3 dir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.DrawLine(transform.position, heading);

		if(Input.GetKeyDown(KeyCode.Z)){
			ShootBall();
		}


	}

	void ShootBall(){
//		Debug.Log ("I SHOT THE BALL!");
		GameObject ball = Instantiate(Ball, transform.position, Quaternion.identity) as GameObject;
		//ball.GetComponent<Rigidbody>().AddForce(heading, ForceMode.Impulse);
//		ball.transform.Translate(Vector3.forward * speed, Space.World);

		cameraPos = Camera.main.transform.position;
		dir = transform.position - cameraPos;
		Vector3 newDir = Camera.main.transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(cameraPos,newDir, Color.magenta);

		ball.GetComponent<Rigidbody>().velocity = newDir *speed;




	}

}
