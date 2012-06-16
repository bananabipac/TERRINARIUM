using UnityEngine;
using System.Collections;

public class TrapeBroyeur : MonoBehaviour {
	public GameObject stock; 
	
	private BroyeurScript broyeur;
	
	// Use this for initialization
	void Start () {
		
		broyeur = stock.GetComponent<BroyeurScript>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
				
		if(other.gameObject.layer == LayerMask.NameToLayer("Lapin")){
			
			if(broyeur.transformation.Count < broyeur.stockage){
				
				MoveLapin(other.gameObject);
				broyeur.transformation.Add(other.gameObject);
				
			}
		}
       
    }
	
	void OnTriggerStay(Collider other) {
		
				
		if(other.gameObject.layer == LayerMask.NameToLayer("Lapin")){
			
			if(broyeur.transformation.Count < broyeur.stockage){
				
				MoveLapin(other.gameObject);
				broyeur.transformation.Add(other.gameObject);
				
			}
		}
       
    }
	
	public void MoveLapin(GameObject lapin){
		
		lapin.rigidbody.isKinematic = true;
		Vector3 vec = broyeur.sortie.transform.position;
		vec.z = -100;
		lapin.transform.position = vec;
		
		
	}
	

	
}
