using UnityEngine;
using System.Collections;

public class DetectBoite : MonoBehaviour {
	
	public GameObject spawn, tapisRoulantMove;
	public float stopDuration;
	
	void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer==LayerMask.NameToLayer("Boite")){
			tapisRoulantMove.GetComponent<TapisRoulantBoite>().StopMove(stopDuration);
			spawn.GetComponent<SpawnViande>().Expulse(stopDuration);
		}
    }
}
