using UnityEngine;
using System.Collections;
using System.IO;


public class Snare : MonoBehaviour {
	public AudioClip D1;
	public AudioClip D2;
	public AudioClip D3;
	private bool played1 = false;
	private bool played2 = false;
	private bool played3 = false;

	public string ani;
	

	public GameObject drumpad1;
	float topD1;
	float bottomD1;
	float leftD1;
	float rightD1;
	float heightD1;
	public GameObject drumpad2;
	float topD2;
	float bottomD2;
	float leftD2;
	float rightD2;
	float heightD2;
	public GameObject drumpad3;
	float topD3;
	float bottomD3;
	float leftD3;
	float rightD3;
	float heightD3;
	
	// Use this for initialization
	void Start () {
		topD1 = drumpad1.transform.position.z + drumpad1.transform.localScale.z / 2;
		bottomD1 = drumpad1.transform.position.z - drumpad1.transform.localScale.z / 2;
		leftD1 = drumpad1.transform.position.x - drumpad1.transform.localScale.x / 2;
		rightD1 = drumpad1.transform.position.x + drumpad1.transform.localScale.x / 2;
		heightD1 = drumpad1.transform.position.y;

		topD2 = drumpad2.transform.position.z + drumpad2.transform.localScale.z / 2;
		bottomD2 = drumpad2.transform.position.z - drumpad2.transform.localScale.z / 2;
		leftD2 = drumpad2.transform.position.x - drumpad2.transform.localScale.x / 2;
		rightD2 = drumpad2.transform.position.x + drumpad2.transform.localScale.x / 2;
		heightD2 = drumpad2.transform.position.y;

		topD3 = drumpad3.transform.position.z + drumpad3.transform.localScale.z / 2;
		bottomD3 = drumpad3.transform.position.z - drumpad3.transform.localScale.z / 2;
		leftD3 = drumpad3.transform.position.x - drumpad3.transform.localScale.x / 2;
		rightD3 = drumpad3.transform.position.x + drumpad3.transform.localScale.x / 2;
		heightD3 = drumpad3.transform.position.y;
	}

	// Update is called once per frame
	void Update () {

		if (transform.position.z < topD1 && transform.position.z > bottomD1 && 
		    transform.position.x < rightD1 && transform.position.x > leftD1 && 
		    transform.position.y > heightD1-0.05 && transform.position.y <= heightD1 && 
		    played1 == false) {
			audio.PlayOneShot (D1);
			played1 = true;
		} else if (transform.position.y > heightD1) {
			played1 = false;
		} 

		if((transform.position.z < topD2 && transform.position.z > bottomD2 && 
		    transform.position.x >leftD2 && transform.position.x < rightD2 && 
		    transform.position.y > heightD2-0.05 && transform.position.y <= heightD2 && 
		    played2 == false)) {
			audio.PlayOneShot (D2);
			played2 = true;
		} else if (transform.position.y > heightD2) {
			played2 = false;
		} 

		if((transform.position.z < topD3 && transform.position.z > bottomD3 && 
		    transform.position.x >leftD3 && transform.position.x < rightD3 && 
		    transform.position.y > heightD3-0.05 && transform.position.y <= heightD3 && 
		    played3 == false)) {
			audio.PlayOneShot (D3);
			played3 = true;
			drumpad3.animation.Play(ani);

		} else if (transform.position.y > heightD3) {
			played3 = false;
		} 


	}
}
