using UnityEngine;
using System.Collections;

public class PopLapin : MonoBehaviour {
	
	public GameObject lapin;
	public float popTime ;
	private float time;
	
	// Use this for initialization
	void Start () {
		
		time = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		time += 1*Time.deltaTime;
		
		if(time >= popTime){
			time = 0;
			
			GameObject lapinTmp = (GameObject) Instantiate(lapin);
			lapinTmp.transform.position = this.transform.position;
		}
	
	}
}
