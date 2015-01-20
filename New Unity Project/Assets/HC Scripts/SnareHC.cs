using UnityEngine;
using System.Collections;
using System.IO;


public class SnareHC : MonoBehaviour {
	public AudioClip snare;
	public AudioClip bpm;
	private bool played = false;
	private int hit = 0;
	private float controlTime = 0;

	public float stopTime;

	public string file;

	float[] x = new float[40];
	float[] y = new float[40];
	float[] rTime = new float[40];

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			audio.PlayOneShot(bpm);
			controlTime = Time.timeSinceLevelLoad;

				}
		if (transform.position.z < 0.25 && transform.position.z > 0 && 
		    transform.position.x < 0.25/2 && transform.position.x > -0.25/2 && 
		    transform.position.y > -0.2 && transform.position.y < 0 && 
		    played == false) {
			audio.PlayOneShot (snare);
			played = true;

			if(controlTime != 0 && hit <= 32){
				x[hit] = transform.position.x;
				y[hit] = transform.position.y;
				rTime[hit] = Time.timeSinceLevelLoad - controlTime;
				hit++;
			}
			if((Time.realtimeSinceStartup - controlTime)>stopTime){
				StreamWriter writetext = new StreamWriter(file +".txt");
				for(int i = 0; i<=33; i++){
					writetext.WriteLine(rTime[i].ToString() + "," + x[i].ToString() + "," + y[i].ToString());
				}

				writetext.Close();
				controlTime = 0;
			}
			
			
		} else if (transform.position.y >= 0) {
			played = false;
		}
		print (Time.realtimeSinceStartup - controlTime);
		
		
	}
}