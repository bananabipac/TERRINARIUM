using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class spawnviandeBocale : MonoBehaviour {

	private float spawnTimer;
	public float spawnDelay;
	public GameObject spawnObject;
	public float forcePropulse;
	public List<GameObject> transformation;
	public int stock;
	// Use this for initialization
	
	private float expulseTimer;
	private bool expulse=false;
	void Start () {
		spawnTimer=Time.time+spawnDelay;
	}
	
	// Update is called once per frame
	void Update () {
		if(expulse){
			if(Time.time>spawnTimer){
				spawnTimer=Time.time+spawnDelay;
				GameObject tmp = (GameObject) Instantiate(spawnObject);
				tmp.transform.position = this.transform.position;
				tmp.rigidbody.AddForce(-Vector3.up * forcePropulse);
			}
			if(Time.time>expulseTimer){
				expulse=false;
			}
		}
	}
	public void Expulse(float stopDuration){
		expulseTimer=Time.time+stopDuration;
		expulse=true;
	}
}
