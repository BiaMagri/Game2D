using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstaculoController : MonoBehaviour {

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
		if (Physics2D.OverlapCircle (groundCheck.position ,0.1f, isObstaculo) || player.position.y < -30) {
			animator.SetBool ("hit", true);
			if (lifeCount.text.Equals("1")) {
				Application.LoadLevel("GameOver");
			} else {
				Vector3 newPosition = Vector3.zero;
				lifeCount.text = "" + (System.Int32.Parse(lifeCount.text.ToString()) - 1);
				newPosition.x = -32;
				newPosition.y = -20;
				newPosition.z = 0;
				player.position = Vector3.Slerp(player.position, newPosition, Time.time);
			}
			animator.SetBool ("hit", false);
		}
	}
}
