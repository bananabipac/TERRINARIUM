using UnityEngine;
using System.Collections;

public class infoUser : MonoBehaviour {
	
	public int money;
	public int score;
	
	
	// Use this for initialization
	void Start () {
		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
        GUI.Label(new Rect(600, 10, 100, 20), "Money : " +money );
    }
}
