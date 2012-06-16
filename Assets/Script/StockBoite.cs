using UnityEngine;
using System.Collections;

public class StockBoite : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
       Destroy(other.gameObject);
    }
}
