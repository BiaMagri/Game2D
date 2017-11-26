using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Animator animator;
	public Rigidbody2D ridibody2D;
	public Transform floorCheckTransform;
	public LayerMask isFloor;
	public int jumpValueY;
	public int velocity;
	public bool onFloor;
	public AudioSource audioController;
	public AudioClip jumpSound;
	public AudioClip shootSound;
	public string sceneName;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("vida", 3);
		//Debug.Log ("Hello");
	}

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		bool walk = Input.GetButton ("Walk");
		bool jump = Input.GetButtonDown ("Jump");
		bool shoot = Input.GetButton ("Fire");
		bool slice = Input.GetButton ("Slice");

		//Cria uma região para verificação, de raio 0.1, situada na mesma posição do objeto
		//groundCheck, verificando a camada isFloor.
		//Salta true caso esteja no chão e false caso esteja no ar
		onFloor = Physics2D.OverlapCircle (floorCheckTransform.position ,0.1f, isFloor);

		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right*velocity*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			walk = true;
		} else if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.right*velocity*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
			walk = true;
		}

		if (onFloor && jump) {
			ridibody2D.AddForce (new Vector2(0, jumpValueY));
			audioController.PlayOneShot (jumpSound);
		}

		if (ridibody2D.velocity.y == 0) {
			onFloor = true;
		}

		if (shoot) {
			audioController.PlayOneShot (shootSound);
		}
		animator.SetBool ("shoot", shoot);
		animator.SetBool ("jump", !onFloor);
		animator.SetBool ("walk", walk);
		animator.SetBool ("slice", slice);
	}

}
