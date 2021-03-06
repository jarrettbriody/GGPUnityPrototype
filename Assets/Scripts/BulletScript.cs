﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public Vector3 direction;
    public float speed;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("FPSController");

    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += direction * speed;
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Target")
        {
            if (collision.gameObject == player.gameObject)
            {
                player.GetComponent<Player>().health -= 20;
            }
            Destroy(gameObject);
        }
    }
}
