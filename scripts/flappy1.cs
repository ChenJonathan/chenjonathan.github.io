using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdController : MonoBehaviour {

	float velocity = 0;

	void Start() {
		
	}
	
	void Update() {
		transform.position += Vector3.up * velocity;
		velocity -= 0.005f;
		if(Input.GetKeyDown(KeyCode.Space)) {
			velocity = 0.15f;
		}
	}
}
