using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHoming : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		transform.LookAt (Vector3.zero);
		rb.velocity = transform.forward * speed;
	}
}
