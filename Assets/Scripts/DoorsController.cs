using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class DoorsController : MonoBehaviour {

	public bool foundPlayer;
	public LayerMask isPlayer;
	public AudioClip doorSound;
	public AudioSource audioController;
	public string fase;
	public Text coinCount;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (fase.Equals ("End")) {
			foundPlayer = Physics2D.OverlapCircle (transform.position, 0.6f, isPlayer);
		} else {
			foundPlayer = Physics2D.OverlapCircle (transform.position ,0.4f, isPlayer);
		}

		if (foundPlayer) {
			audioController.PlayOneShot (doorSound);
			PlayerPrefs.SetInt ("coins", PlayerPrefs.GetInt("coins", 0) + System.Int32.Parse(coinCount.text));
			Debug.Log ("Moedas: ");
			Debug.Log (PlayerPrefs.GetInt ("coins", 0));
			SceneManager.LoadScene (fase);
		}

	}
}
