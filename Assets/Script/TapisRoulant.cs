using UnityEngine;
using System.Collections;

public class TapisRoulant : MonoBehaviour {

	public float translateSpeed;
	
	
	void OnTriggerStay(Collider other) {
        if(other.gameObject.layer==LayerMask.NameToLayer("Boite")||other.gameObject.layer==LayerMask.NameToLayer("Lapin")){
			other.gameObject.transform.Translate(translateSpeed*Time.deltaTime,0,0);
/*			if (other.attachedRigidbody) {
				other.attachedRigidbody.AddForce(Vector3.right * 10);
			}*/
		}
    }
	
	
	
}
