using UnityEngine;
using System.Collections;

public class DetectAssaisonement : MonoBehaviour {
	
	public GameObject spawn;
	public float stopDuration;
	
	void OnTriggerEnter(Collider other) {
       if(other.gameObject.layer==LayerMask.NameToLayer("Lapin")){
			spawn.GetComponent<SpawnViande>().Expulse(stopDuration);
		}
    }
}
