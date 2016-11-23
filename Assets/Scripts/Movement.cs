using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;

	// Use this for initialization
	void Start () {
//		movementTest.transform.position =  gyroTest.userAcceleration;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.acceleration.x < -0.1f) {
			moveLeft ();
		} else if (Input.acceleration.x > 0.1f) {
			moveRight ();
		} 

		if (Input.acceleration.y > 0.1f) {
			moveForward ();
		} else if (Input.acceleration.y < -0.1f) {
			moveBackward ();
		} 

		if(Input.acceleration.x > -0.1f
			&& Input.acceleration.x < 0.1f
			&& Input.acceleration.y > -0.1f
			&& Input.acceleration.y < 0.1f){
			stopMovement ();
		}
	}

	void moveLeft(){
		rb.AddForce (new Vector2 (-speed, 0));
	}

	void moveRight(){
		rb.AddForce (new Vector2 (speed, 0));
	}

	void moveForward(){
		rb.AddForce (new Vector2 (0, speed));
	}

	void moveBackward(){
		rb.AddForce (new Vector2 (0, -speed));
	}

	void stopMovement(){
		rb.velocity = Vector2.zero;
	}
}
