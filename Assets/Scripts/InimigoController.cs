using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InimigoController : MonoBehaviour {

	public int velocity;
	public Transform limiterR;
	public Transform limiterL;

	public LayerMask isObstaculo;
	public Transform groundCheck;
	public Transform player;
	public Animator animator;
	public Text lifeCount;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.right*velocity*Time.deltaTime);

		if (Mathf.Abs(transform.position.x - limiterR.position.x) < 0.5f) {
			transform.eulerAngles = new Vector2 (0, 180);
		}
		if (Mathf.Abs(transform.position.x - limiterL.position.x) < 0.5f) {
			transform.eulerAngles = new Vector2 (0, 0);
		}
			
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag.Equals("Player")){
			if (!lifeCount.text.Equals("1")) {
				Vector3 newPosition = Vector3.zero;
				lifeCount.text = "" + (System.Int32.Parse(lifeCount.text.ToString()) - 1);
				newPosition.x = -32;
				newPosition.y = -20;
				newPosition.z = 0;
				player.position = Vector3.Slerp(player.position, newPosition, Time.time);
			} else {
				Application.LoadLevel("GameOver");
			}

		}
	}

}
