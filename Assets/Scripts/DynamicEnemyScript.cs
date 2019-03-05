using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicEnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Mathf.Sin(Time.time) * 5.0f, 0.0f, 0.0f));
	}
}
