using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanShoot : MonoBehaviour {
	public float range;
	Camera fpsCamera;
	// Use this for initialization
	void Start () {
		fpsCamera = GetComponentInChildren<Camera>();
	}

	public void Fire()
	{
		Vector3 rayOrigin = fpsCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
		RaycastHit raycast;
		if(Physics.Raycast(rayOrigin, fpsCamera.transform.forward, out raycast, range))
		{
			if (raycast.collider.CompareTag("Target")){
				Destroy(raycast.collider.gameObject);
			}
		}
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Fire();
		}
	}
}
