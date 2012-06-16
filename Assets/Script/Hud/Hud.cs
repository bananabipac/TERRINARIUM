using UnityEngine;
using System.Collections;

public class Hud : MonoBehaviour {

	void OnGUI(){
		GUI.Label(new Rect(0,0,1000,50),Argent.argent.ToString());
	}
}
