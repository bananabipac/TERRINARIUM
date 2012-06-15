using UnityEngine;
using System.Collections;

public class TapisRoulant : MonoBehaviour {

	public float translateSpeed;
	public string target;
	void OnTriggerStay(Collider other) {
        if(other.gameObject.layer==LayerMask.NameToLayer(target)){
			other.gameObject.transform.Translate(translateSpeed*Time.deltaTime,0,0);
		}
			
        
    }


}
