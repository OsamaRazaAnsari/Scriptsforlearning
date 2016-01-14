using UnityEngine;
using System.Collections;

public class camera_controller : MonoBehaviour {
	public Transform car;
	public float Distance=6.6f;
	public float height=11.3f;
	public float rotatingDumping=3.0f;
	public float heightDumping=10.3f;
	public float zoomratio=.5f;
	public Vector3 rotationvector;
	// Use this for initialization
	void Start () {
		height=2.7f;
		heightDumping=10.3f;

	}
	
	// Update is called once per frame
	void LateUpdate () {
		float wantedAngle = car.eulerAngles.y;
        float wantedHeight = car.position.y+height;
		float myAngel = transform.eulerAngles.y;
		float myHeight = transform.position.y; 	
		myAngel = Mathf.LerpAngle (myAngel, wantedAngle, rotatingDumping * Time.deltaTime);
		myHeight = Mathf.Lerp (myHeight, wantedHeight, heightDumping * Time.deltaTime);
		Quaternion currentRotation = Quaternion.Euler (0, myAngel, 0);
		transform.position = new Vector3 (car.position.x, myHeight, car.position.z);
		transform.position -= currentRotation * Vector3.forward * Distance;
		transform.LookAt (car);


	}
}
