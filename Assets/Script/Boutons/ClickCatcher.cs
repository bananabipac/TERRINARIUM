using UnityEngine;
using System.Collections;

public class ClickCatcher : MonoBehaviour {
	public GameObject[] buttons;
	
	void OnMouseDown () {
		buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach (GameObject button in buttons) {	 
			button.active=false;
        }
   	}
	
	
}
