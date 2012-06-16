using UnityEngine;
using System.Collections;

public class palScript : MonoBehaviour {
	public bool invert;
	public float speed;
	public Transform[] path;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!invert){
			this.transform.Translate( -1*speed*Time.deltaTime, 0, 0);
			if(this.transform.position.y >= path[0].transform.position.y){
				invert = true;
				
				
			}
		}
		
		if(invert){
			
			this.transform.Translate(speed*Time.deltaTime, 0, 0);
			if(this.transform.position.y <= path[1].transform.position.y){
				invert = false;
			}
		}
			
	
	}
	void OnDrawGizmos(){
	
		iTween.DrawPath(path, Color.green);
		
	}

	
}
