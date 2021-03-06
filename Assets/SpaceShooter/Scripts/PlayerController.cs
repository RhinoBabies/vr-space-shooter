﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}
*/

public class PlayerController : MonoBehaviour {

//	private Rigidbody rb;
	private AudioSource audioSource;

/* variables used for arcade style space-shooter
	public float speed;
	public float tilt;
	public Boundary boundary;
*/

	public GameObject bolt;
	public Transform shotSpawn; //avoids having to type shotSpawn.transform.position/rotation; Unity will recognize transform of the GameObject
	public float fireRate = 0.5f;

	private float nextFire = 0.0f;

	void Start()
	{
//		rb = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
	}

	void Update()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (bolt, shotSpawn.position, shotSpawn.rotation);
			audioSource.Play ();
		}
	}

/* unnecessary for VR game
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed; 

		rb.position = new Vector3
		(
			Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
		);

		rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * -tilt);
	}
*/
}
