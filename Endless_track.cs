using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 class Endless_track : MonoBehaviour {
	public List<Transform> track=new List<Transform>();
	private Transform[] clone=new Transform[3];
	public List<Transform> trackadd=new List<Transform>();
	public Vector3 _bound=Vector3.zero;
	public Transform player;

	int i=0,j=0,k=1;
	// Use this for initialization
	void Start () {
			for (int i=0; i<3; i++) {
			clone[i]=(Transform)Instantiate (track [i],_bound, Quaternion.identity);
		_bound= _bound+(track[i].GetComponent<MeshRenderer> ().bounds.extents-new Vector3(track[0].localScale.x/2,0.5f,0))+new Vector3(0,0,track[0].localScale.z/2);    
			//Debug.Log(_bound);
		}

}		// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log (_bound);

		if (player.transform.position.z > 40*k  && player.transform.position.z < 42*k  ) {
			//Debug.Log (j);
			Destroy (clone [j].gameObject);
			clone [j] = (Transform)Instantiate (track [j], _bound, Quaternion.identity);
			_bound = _bound + (track [j].GetComponent<MeshRenderer> ().bounds.extents - new Vector3 (track [0].localScale.x / 2, 0.5f, 0)) + new Vector3 (0, 0, track [0].localScale.z / 2);    
			j++;
			k++;
		}
				if (j == 3) {
				j=0;
			}
			
	}
	}

