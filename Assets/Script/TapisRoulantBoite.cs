using UnityEngine;
using System.Collections;

public class TapisRoulantBoite : MonoBehaviour {

	public float translateSpeed;
	
	public bool move=true;
	
	private float stopTimer;
	
	void OnTriggerStay(Collider other) {
		if(move){
			if(other.gameObject.layer==LayerMask.NameToLayer("Boite")||other.gameObject.layer==LayerMask.NameToLayer("Lapin")){
				other.gameObject.transform.Translate(translateSpeed*Time.deltaTime,0,0);
	/*			if (other.attachedRigidbody) {
					other.attachedRigidbody.AddForce(Vector3.right * 10);
				}*/
			}
		}
    }
	void Update(){
		if(!move&&Time.time>stopTimer){
			move=true;
		}
	}
	public void StopMove(float stopDuration){
		move=false;
		stopTimer=Time.time+stopDuration;
		
	}
	
	
	
}
