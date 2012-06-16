using UnityEngine;
using System.Collections;

public class EmpacteBoite : MonoBehaviour {
	public GameObject top;
	// Use this for initialization
	void Start () {
		top.active=false;
	}
	
	public void Empacte () {
		top.active=true;
	}
}
