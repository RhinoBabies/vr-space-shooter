using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseAsteroidSpawn : MonoBehaviour {
	public GameController gameController;
	public GameObject thisExplosion;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bolt") {
			gameController.waveWait--;
			Instantiate (thisExplosion, transform.position, transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
