using UnityEngine;
using System.Collections;
public class Generate_coin : MonoBehaviour {
	Endless_track obj_Endless_track;
	public Transform coin;
	Transform _player;
	int r=1;
	int i=0;
	public Transform[] _clone =new Transform[6];
	void Start () {
		obj_Endless_track = GetComponent<Endless_track> ();
		_player=obj_Endless_track.player;
	}
	// Update is called once per frame
	void Update () {
		
		if(_player.transform.position.z>40*r &&_player.transform.position.z<41*r){
			float f_point_coin=Random.Range(-7f,7f);
			for(float f=obj_Endless_track.player.position.z+20;f<=(obj_Endless_track.player.position.z+20)+5f;f++){
				if(i<6){
					_clone[i]=(Transform)Instantiate(coin,new Vector3(f_point_coin,1.25f,f+1f),Quaternion.identity);
				
					i++;	
				}if(i==6){
					i=0;	
					r++;
				}
				
				
			}
			

			
			Debug.Log(true);
		}
		//		if (_player.position.z > 60 && _player.position.z < 61) {
		//			foreach(Transform obj in _clone){
		//				Destroy(obj.gameObject);
		//				//i=0;
		//				Debug.Log(true);
		//				
		//			}
		//			  }
		
		
		
	}
	
	
	
	
}


