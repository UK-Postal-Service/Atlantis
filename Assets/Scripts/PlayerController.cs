using UnityEngine;
using System.Collections;

// Use require component to ensure that any object with this script has a rigidbody
[RequireComponent (typeof (Rigidbody2D))]
public class PlayerController : MonoBehaviour {

	public float walkSpeed = 1;

	public float jumpForce = 1;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		// Get a reference to the physics of the object
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		// TODO: Apply a force when the player moves
		// Use the horizontal axis multiplied by the speed


		// TODO: Apply upward force when player presses jump button
		if (Input.GetButtonDown ("Jump")) {

		}
	}
}
