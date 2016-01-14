using UnityEngine;
using System.Collections;

public class Rotate_coin : MonoBehaviour {
    Generate_coin coin;
	// Use this for initialization
	void Start () {
		coin = GetComponent<Generate_coin> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(coin._clone[0]!=null){
			Debug.Log(true);
			foreach(Transform get_clone_coin in coin._clone){
				get_clone_coin.transform.Rotate(0,4f,0);
			}


		}
	}
}
