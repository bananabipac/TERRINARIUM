using UnityEngine;
using System.Collections;

public class MonteChargeScript : MonoBehaviour {
	
	public Transform[] path;
	public GameObject[] pals;

	// Use this for initialization
	void Start () {
		for(int i =0; i<pals.Length; i++){
			iTween.MoveTo(pals[i], iTween.Hash("path" , path,
											  "orienttopath", true,
		                                      "speed", 1f,
		                                      "looktime", 0.1f,
		                                      "looptype" , "loop", 
                              				  "easetype", "linear")); 
	
		}
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnDrawGizmos(){
	
		iTween.DrawPath(path, Color.green);
		
	}
}
