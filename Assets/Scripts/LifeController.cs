using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour {

	public AudioSource audioController;
	public AudioClip heartSound;
	public LayerMask isPlayer;
	public Text lifeCount;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Physics2D.OverlapCircle(transform.position, 0.06f, isPlayer)){
			lifeCount.text = "" + (System.Int32.Parse(lifeCount.text.ToString()) + 1);
			audioController.PlayOneShot (heartSound);
			Destroy(gameObject);
		}
	}
}
