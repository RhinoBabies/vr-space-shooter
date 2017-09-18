using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public GameObject treasure;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public GameObject scoreText;
	public GameObject restartText;
	public GameObject gameOverText;

	private int score;
	private bool gameOver;
	private bool restart;

	void Start()
	{
		gameOver = false;
		restart = false;
		scoreText.SetActive (false);
		restartText.SetActive (false);
		gameOverText.SetActive (false);
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	void Update()
	{
		if (restart) {
			if (Input.GetButton("Jump")) {
				SceneManager.LoadScene ("vr-space");
			}
		}
	}

	IEnumerator SpawnWaves()
	{
		//pause for player readiness
		yield return new WaitForSeconds (startWait);
		while(true)
		{
			for(int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x,spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				if (i > 5) {
					if (Random.Range (0, 10) < 3) {
						Instantiate(treasure, spawnPosition, spawnRotation);
						yield return new WaitForSeconds (spawnWait);
					}
				}
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait); //delay spawning of asteroids to avoid collisions between them
			}
			hazardCount++;
			yield return new WaitForSeconds (waveWait);

			if (gameOver) {
				restartText.SetActive(true);
				restart = true;
				break;
			}
		}
	}
		
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore()
	{
		//need Score Text to work properly on canvas
	}

	public void GameOver()
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
