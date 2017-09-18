using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDWarning : MonoBehaviour {
	public GameObject warningParticles;

	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.name + " inside radar " + gameObject.name);
		if (other.tag == "Asteroid") {
			warningParticles.SetActive (true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log(other.name + " left radar " + gameObject.name);
		if (other.tag == "Asteroid") {
			warningParticles.SetActive (false);
		}
	}
}
