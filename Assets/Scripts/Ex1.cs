using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ex1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Não esquecer de adicionar no Build Settings
	}

	// Update is called once per frame
	void Update () {
		bool start = Input.anyKeyDown;

		if (start) {
			SceneManager.LoadScene ("Fase1");
		}
	}
}
