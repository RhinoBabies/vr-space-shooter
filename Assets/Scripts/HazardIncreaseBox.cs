using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardIncreaseBox : MonoBehaviour {
	public GameController gameController;
	public GameObject thisExplosion;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bolt") {
			gameController.hazardCount = gameController.hazardCount + 5;
			Instantiate (thisExplosion, transform.position, transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
