using UnityEngine;
using System.Collections;

public class SpawnViande : MonoBehaviour {

	private float spawnTimer;
	public float spawnDelay;
	public GameObject spawnObject;
	public float forcePropulse;
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
				((GameObject)Instantiate(spawnObject, transform.position, transform.rotation)).rigidbody.AddForce(-Vector3.up * forcePropulse);
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
