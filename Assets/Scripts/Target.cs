using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public GameObject bulletPrefab;
    float lastB = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - lastB >= 2.0f)
        {
            lastB = Time.time;
            GameObject b = Instantiate(bulletPrefab);
            b.transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
            b.GetComponent<BulletScript>().direction = (GameObject.Find("FPSController").gameObject.transform.position - gameObject.transform.position).normalized;
            b.GetComponent<BulletScript>().speed = 0.3f;
        }
	}
}
