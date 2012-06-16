using UnityEngine;
using System.Collections;

public class TapisRoulant : MonoBehaviour {

	public float translateSpeed;
	
	
	private float usure;
	public float usureMax=100;
	public float usureParUtilisation=1;
	public GameObject[] usureLvls;
	
		// Use this for initialization
	void Start () {
		usure=usureMax;
		foreach(GameObject g in usureLvls){
			foreach(Transform t in g.transform){
				t.gameObject.active=false;
				
			}
		}
	}
	
	void Usure(){
		usure-=usureParUtilisation;
		if(usure<75){
			foreach(Transform t in usureLvls[0].transform){
				t.gameObject.active=true;
			}
			if(usure<50){
				foreach(Transform t in usureLvls[1].transform){
					t.gameObject.active=true;
				}		
				if(usure<25){
					foreach(Transform t in usureLvls[2].transform){
						t.gameObject.active=true;
					}	
					if(usure<0){
						//Debug.Log("OMG NOOB TU RUIIIIINEEEEEEEEEEEEEEEEEEEUH!");
					}
				}
			}
		}
	}
	void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer==LayerMask.NameToLayer("Lapin")||other.gameObject.layer==LayerMask.NameToLayer("Boite")){
			Usure();
		}
    }
	
	void OnTriggerStay(Collider other) {
        if(other.gameObject.layer==LayerMask.NameToLayer("Boite")||other.gameObject.layer==LayerMask.NameToLayer("Lapin")){
			other.gameObject.transform.Translate(translateSpeed*Time.deltaTime,0,0);
/*			if (other.attachedRigidbody) {
				other.attachedRigidbody.AddForce(Vector3.right * 10);
			}*/
		}
    }
	
	
	
}
