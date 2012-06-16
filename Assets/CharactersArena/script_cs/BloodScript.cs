using UnityEngine;
using System.Collections;

public class BloodScript : MonoBehaviour {
	public GameObject[] bloods;
	public float delay;
	private float timer;
	private int i=0;

	void Start(){
		timer=Time.time+delay;
		Destroy(gameObject, 3f);
	}
	
	void Update () {
		if(Time.time>timer){
			timer=Time.time+delay;	
			bloods[i].active=true;
			bloods[i].transform.parent=null;
			i++;
			if(i==bloods.Length){
				Destroy(gameObject);	
			}
		}
	}
}
