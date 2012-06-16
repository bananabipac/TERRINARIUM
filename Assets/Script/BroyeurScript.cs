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
	private float timeInstance ; 
	private float timeInstanceTmp ;
	public bool pack;
	
	// Use this for initialization
	void Start () {
		timeInstance = 0.1f;
	}

	// Update is called once per frame
	void Update () {
		
	
		
		if(transformation.Count >0){
			time += 1*Time.deltaTime;
			
			if(time >= timeTransforme){
				time = 0;
				if(pack && transformation.Count >= stockage){
					for(int i =0; i<transformation.Count; i++){
						GameObject tmp = transformation[0];
						Destroy(tmp);
						transformation.RemoveAt(0);	
					}
					for(int i = 0; i<nbMorceaux;i++){
						
						while(timeInstanceTmp < timeInstance){
							timeInstanceTmp += 1*Time.deltaTime;
						}
						
						//Debug.Log("fdgfd");
						GameObject morceau = (GameObject) Instantiate(lapinStadeFinal);
						morceau.transform.position = this.transform.position;
						timeInstanceTmp = 0;
					}
					Usure();
				}else{
					
					GameObject tmp = transformation[0];
					Destroy(tmp);
					transformation.RemoveAt(0);
					//Debug.Log("broyage");
					for(int i = 0; i<nbMorceaux;i++){
						
						while(timeInstanceTmp < timeInstance){
							timeInstanceTmp += 1*Time.deltaTime;
						}
						
						//Debug.Log("fdgfd");
						GameObject morceau = (GameObject) Instantiate(lapinStadeFinal);
						morceau.transform.position = this.transform.position;
						timeInstanceTmp = 0;
					}
					Usure();
				}
			}	
		}
	}
	
	void Usure(){
		GetComponent<ProductionPart>().Usure();
	}
	
}
