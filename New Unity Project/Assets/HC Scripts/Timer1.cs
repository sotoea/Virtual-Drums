using UnityEngine;
using System.Collections;

public class Timer1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//print (Time.realtimeSinceStartup);
		if (Input.GetKey("escape"))
						Application.Quit ();
	}
}
