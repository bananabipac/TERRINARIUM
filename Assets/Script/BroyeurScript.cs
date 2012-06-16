using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BroyeurScript : MonoBehaviour {
	
	public GameObject lapinStadeFinal;
	public List<GameObject> transformation;
	public int stockage;
	public GameObject sortie;
		
	public float timeTransforme; 
	private float time;
	public int nbMorceaux;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if(transformation.Count >0){
			time += 1*Time.deltaTime;
			
			if(time >= timeTransforme){
				time = 0;
				GameObject tmp = transformation[0];
				Destroy(tmp);
				transformation.RemoveAt(0);
				//Debug.Log("broyage");
				for(int i = 0; i<nbMorceaux;i++){
					GameObject morceau = (GameObject) Instantiate(lapinStadeFinal);
					morceau.transform.position = this.transform.position;
				}
			}
			
		}
		
		
	
	}

	
	
	
	
}
