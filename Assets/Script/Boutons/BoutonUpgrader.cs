using UnityEngine;
using System.Collections;

public class BoutonUpgrader : MonoBehaviour {

	void OnGUI(){
		Vector3 v=Camera.main.WorldToScreenPoint(transform.position);
		if (GUI.Button(new Rect(v.x,Screen.height-v.y,100,20),"Upgrader")){
			transform.parent.SendMessage("Upgrader");
			GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
       		foreach (GameObject button in buttons) {	 
				button.active=false;
       		}
		}
	}
}
