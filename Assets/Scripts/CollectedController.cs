using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedController : MonoBehaviour {

	public AudioSource audioController;
	public AudioClip coinSound;
	public LayerMask isPlayer;
	public Text coinCount;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Physics2D.OverlapCircle(transform.position, 0.06f, isPlayer)){
			coinCount.text = "" + (System.Int32.Parse(coinCount.text.ToString()) + 1);
			audioController.PlayOneShot (coinSound);
			Destroy(gameObject);
		}
	}
}
