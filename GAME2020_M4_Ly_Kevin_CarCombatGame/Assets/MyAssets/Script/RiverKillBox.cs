using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverKillBox : MonoBehaviour {

	public GameObject playerReference;



	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider other) {

		Destroy (playerReference);
	}
}
