using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	float speed=0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(0,0,speed+.25f);
		float _InputControl = Input.GetAxis ("Horizontal");
		//	_InputControl *= 9f;
		this.transform.Translate (_InputControl,0,speed);
		
	}
}
