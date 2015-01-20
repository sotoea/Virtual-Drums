using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour {
	public GameObject finger;
	public GameObject finger2;
	// Use this for initialization
	float topD1;
	float bottomD1;
	float leftD1;
	float rightD1;
	float heightD1;
	Vector3 colorf;

	public float timee = 0;

	void Start () {
		topD1 = transform.position.z + transform.localScale.z / 2;
		bottomD1 = transform.position.z - transform.localScale.z / 2;
		leftD1 = transform.position.x - transform.localScale.x / 2;
		rightD1 = transform.position.x + transform.localScale.x / 2;
		heightD1 = transform.position.y;

		colorf.x = Random.value;
		colorf.y = Random.value;
		colorf.z = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
		if (timee > 0) {
						timee = timee - 1f;
				} else if(timee == 0){
						renderer.material.color = new Color (1, 1, 1);
			timee = -1;
				}
		if ((finger.transform.position.x < rightD1 && finger.transform.position.x > leftD1 && finger.transform.position.z < topD1 && finger.transform.position.z> bottomD1 && finger.transform.position.y > heightD1-0.05 && finger.transform.position.y < heightD1)||
		    (finger2.transform.position.x < rightD1 && finger2.transform.position.x > leftD1 && finger2.transform.position.z < topD1 && finger2.transform.position.z> bottomD1 && finger2.transform.position.y > heightD1-0.05 && finger2.transform.position.y<heightD1)) {
						renderer.material.color = new Color (colorf.x,colorf.y,colorf.z);
			timee = 5;
				} //else {
						//renderer.material.color = new Color (1, 1, 1);
				//}
	}
}
