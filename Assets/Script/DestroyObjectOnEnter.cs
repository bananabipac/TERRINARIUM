using UnityEngine;
using System.Collections;

public class DestroyObjectOnEnter : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
       Destroy(other.gameObject);
    }
}
