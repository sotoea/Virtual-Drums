using UnityEngine;
using System.Collections;

public class Teacher : MonoBehaviour {
	private float timee=0;
	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	public GameObject bombo;
	public GameObject snare;
	private float interval = 50;
	private bool vary = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print (Time.realtimeSinceStartup - timee);
		SixenseInput.Controller rightHand = SixenseInput.GetController(SixenseHands.RIGHT);
		if (rightHand.GetButtonDown (SixenseButtons.ONE)) {
			timee = Time.realtimeSinceStartup;
			one.animation.Play("sp");
			two.animation.Play ("sp0");
			three.animation.Play ("sp9");
			four.animation.Play ("sp8");
		} 
		if (timee != 0) {
			if((Time.realtimeSinceStartup - timee) >= interval && (Time.realtimeSinceStartup - timee) <=(interval+0.6)){
				interval += 0.79f;
				if(vary){
					bombo.renderer.material.color = new Color (0f,0.2f,0.6f);
					bombo.animation.Play("colorChange");
					//bombo.renderer.material.color = new Color(0,1,0);
					snare.renderer.material.color = new Color(1,1,1);
				}else{
					snare.renderer.material.color = new Color (0f,0.2f,0.6f);
					snare.animation.Play("colorChange2");
					//snare.renderer.material.color = new Color(0,1,0);
					bombo.renderer.material.color = new Color(1,1,1);
				}
				vary = !vary;
			}
		}
	}
}
