using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Não esquecer de adicionar no Build Settings
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown) {
			SceneManager.LoadScene ("Ex1");
		}
	}
}
