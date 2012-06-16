using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	private float spawnTimer;
	public float spawnDelay;
	public GameObject spawnObject;
	// Use this for initialization
	void Start () {
		spawnTimer=Time.time+spawnDelay;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time>spawnTimer){
			spawnTimer=Time.time+spawnDelay;
			Instantiate(spawnObject, transform.position, transform.rotation);
		}
	}
}
