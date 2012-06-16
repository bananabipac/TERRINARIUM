using UnityEngine;
using System.Collections;

public class ProductionPart : MonoBehaviour {

	private float usure;
	public float usureMax=100;
	public float usureParUtilisation=1;
	public float coutReparation=100;
	public float[] coutUpgrade={100,200,400,800};
	public int lvlUpgrade=0;
	public GameObject[] usureLvls;
	
	public GameObject[] buttons;
	
	void Start(){
		usure=usureMax;
		foreach(GameObject g in usureLvls){
			foreach(Transform t in g.transform){
				t.gameObject.active=false;
			}
		}
		foreach(GameObject g in buttons){
			g.active=false;
		}
	}
	
	public void Usure(){
		usure-=usureParUtilisation;
		if(usure<=80){
			foreach(Transform t in usureLvls[0].transform){
				t.gameObject.active=true;
			}
			if(usure<=60){
				foreach(Transform t in usureLvls[1].transform){
					t.gameObject.active=true;
				}		
				if(usure<=40){
					foreach(Transform t in usureLvls[2].transform){
						t.gameObject.active=true;
					}	
					if(usure<=20){
						foreach(Transform t in usureLvls[3].transform){
							t.gameObject.active=true;
						}	
						if(usure<=0){
							//Debug.Log("OMG NOOB TU RUIIIIINEEEEEEEEEEEEEEEEEEEUH!");
						}
					}
				}
			}
		}
	}
	
	public void OnMouseDown () {
		foreach(GameObject g in buttons){
			g.active=true;
		}
	}
/*	public void OnMouseUp () {
		Debug.Log(gameObject.name+" up");
	}*/
	
	public void Reparer(){
		usure=usureMax;
		if(Argent.DepenseArgent(coutReparation)){
			foreach(GameObject g in usureLvls){
				foreach(Transform t in g.transform){
					t.gameObject.active=false;
				}
			}
			Argent.PerdreArgent(coutReparation);
		}
	}
	
	public void Upgrader(){
		if(lvlUpgrade<coutUpgrade.Length&&Argent.DepenseArgent(coutUpgrade[lvlUpgrade])){
			///
			//DO SOMETHING BIATCH!!!!
			//
			Argent.PerdreArgent(coutUpgrade[lvlUpgrade]);
			lvlUpgrade++;
		}
	}
	
	public void Downgrader(){
		if(lvlUpgrade-1>=0){
			///
			//DO SOMETHING BIATCH!!!!
			//
			lvlUpgrade--;
			Argent.GagnerArgent(coutUpgrade[lvlUpgrade]/2);
		}
	}
}
