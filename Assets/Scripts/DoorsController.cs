using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DoorsController : MonoBehaviour {

	public bool foundPlayer;
	public LayerMask isPlayer;
	public AudioClip doorSound;
	public AudioSource audioController;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		foundPlayer = Physics2D.OverlapCircle (transform.position ,0.4f, isPlayer);

		if (foundPlayer) {
			audioController.PlayOneShot (doorSound);
			SceneManager.LoadScene ("Fase2");
		}

	}
}
