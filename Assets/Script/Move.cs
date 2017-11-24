using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	private Rigidbody myRb;

	// Use this for initialization
	void Start () {
		myRb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("z")){
			myRb.AddForce(Vector3.forward * 3, ForceMode.Impulse);
		}
		else if (Input.GetKey("s")){
			myRb.AddForce(Vector3.back * 3, ForceMode.Impulse);
		}
	}
}
