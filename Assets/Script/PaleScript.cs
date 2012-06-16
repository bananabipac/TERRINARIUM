using UnityEngine;
using System.Collections;

public class PaleScript : MonoBehaviour {

	public float animStartPos;
	
	public float animSpeedModif=1f;

	// Use this for initialization
	void Start () {
		animation["PaleAnimation"].normalizedTime=animStartPos;
		animation["PaleAnimation"].speed=animSpeedModif;
	}
	
}
