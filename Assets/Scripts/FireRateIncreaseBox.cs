using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRateIncreaseBox : MonoBehaviour {
	private PlayerController playerController;
	public GameObject thisExplosion;

	void Start()
	{
		GameObject player = GameObject.FindWithTag ("Player");
		if (player != null)
			playerController = player.GetComponent<PlayerController> ();
		else
			Debug.Log("Player tag not found.");
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bolt") {
			playerController.fireRate = playerController.fireRate / 2.0f;
			Instantiate (thisExplosion, transform.position, transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
