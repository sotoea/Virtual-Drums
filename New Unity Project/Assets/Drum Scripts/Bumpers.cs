using UnityEngine;
using System.Collections;

public class Bumpers : MonoBehaviour {
	public AudioClip D1;
	public AudioClip D2;
	public AudioClip wallups;
	public AudioClip Prototype;
	private bool wallup = true;
	public GameObject hihat;
	public GameObject wall;
	public GameObject table;
	public GameObject couch;
	private float volume = 0.0f;

	public GameObject bassD;
	private Color colour;

	
	// Use this for initialization
	void Start () {
		colour = new Color (Random.value, Random.value, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("r")){
			Application.LoadLevel(0);
		}

		SixenseInput.Controller rightHand = SixenseInput.GetController(SixenseHands.RIGHT);
		SixenseInput.Controller leftHand = SixenseInput.GetController(SixenseHands.LEFT);
		if (rightHand.GetButtonDown (SixenseButtons.TRIGGER)) {
			audio.PlayOneShot (D1);
			bassD.renderer.material.color = colour;
		} else if (rightHand.GetButtonUp (SixenseButtons.TRIGGER)) { 
			bassD.renderer.material.color = new Color (1, 1, 1);
		}
		else if (leftHand.GetButtonDown (SixenseButtons.TRIGGER)) {
			hihat.animation.Play("HiUp");
			audio.PlayOneShot(D2);
		} else if (leftHand.GetButtonUp(SixenseButtons.TRIGGER)){
			hihat.animation.Play("HiDown");
			//audio.PlayOneShot(D2);
		} else if (wallup && rightHand.GetButtonDown(SixenseButtons.ONE)){
			wallup = false;
			wall.animation.Play("WallUp");
			table.animation.Play("tableMove");
			couch.animation.Play("couchMove");
			audio.PlayOneShot(wallups);
			audio.PlayOneShot(Prototype);
			volume = 0.001f;
			audio.volume = volume;


		}
		if (volume != 0f && volume < 1f) {
			volume += 0.01f;
			audio.volume = volume;
				}
		else if ( volume >= 0.9f) {

			//audio.volume -= 0.003f;
		}
		
	}
}
