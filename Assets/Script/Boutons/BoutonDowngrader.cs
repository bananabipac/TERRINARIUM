using UnityEngine;
using System.Collections;

public class BoutonDowngrader : MonoBehaviour {

	void OnGUI(){
		Vector3 v=Camera.main.WorldToScreenPoint(transform.position);
		if (GUI.Button(new Rect(v.x,Screen.height-v.y,100,20),"Downgrader")){
			transform.parent.SendMessage("Downgrader");
			GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
       		foreach (GameObject button in buttons) {	 
				button.active=false;
       		}
		}
	}
}