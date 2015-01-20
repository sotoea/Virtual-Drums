using UnityEngine;
using System.Collections;

public class cChangeHC : MonoBehaviour {
	public GameObject finger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (finger.transform.position.z>0 && finger.transform.position.z <0.25 && finger.transform.position.x>-0.25/2 && finger.transform.position.x<0.25/2 && finger.transform.position.y > -0.2 && finger.transform.position.y < 0){
			renderer.material.color = new Color (1, 0, 0);
		} else {
			renderer.material.color = new Color (1, 1, 1);
		}
	}
}
