using UnityEngine;
using System.Collections;

public class changeColor2 : MonoBehaviour {
	public GameObject finger;
	public GameObject finger2;
	// Use this for initialization
	float topD1;
	float bottomD1;
	float leftD1;
	float rightD1;
	float heightD1;
	void Start () {
		topD1 = transform.position.z + transform.localScale.z / 2;
		bottomD1 = transform.position.z - transform.localScale.z / 2;
		leftD1 = transform.position.x - transform.localScale.x / 2;
		rightD1 = transform.position.x + transform.localScale.x / 2;
	}
	
	// Update is called once per frame
	void Update () {
		if ((finger.transform.position.x < rightD1 && finger.transform.position.x > leftD1 && finger.transform.position.z < topD1 && finger.transform.position.z> bottomD1 && finger.transform.position.y > -0.2 && finger.transform.position.y < 0)||
		    (finger2.transform.position.x < rightD1 && finger2.transform.position.x > leftD1 && finger2.transform.position.z < topD1 && finger2.transform.position.z> bottomD1 && finger2.transform.position.y > -0.2 && finger2.transform.position.y<0)) {
			renderer.material.color = new Color (0, 0, 1);
		} else {
			renderer.material.color = new Color (1, 1, 1);
		}
	}
}
