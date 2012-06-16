using UnityEngine;
using System.Collections;

public class DetectBoiteEmpacte : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer==LayerMask.NameToLayer("Boite")){
			other.gameObject.GetComponent<EmpacteBoite>().Empacte();
		}
    }
}
