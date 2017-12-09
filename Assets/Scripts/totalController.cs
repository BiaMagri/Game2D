using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalController : MonoBehaviour {

	public Text coinCount;

	// Use this for initialization
	void Start () {
		coinCount.text = "" + PlayerPrefs.GetInt ("coins", 0);
	}
	
	// Update is called once per frame
	void Update () {
		coinCount.text = "" + PlayerPrefs.GetInt ("coins", 0);
	}
}
