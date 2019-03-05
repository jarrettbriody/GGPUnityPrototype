using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

    public Texture crosshairImage;
    public float crosshairScale = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crosshairImage.width * crosshairScale / 2);
        float yMin = (Screen.height / 2) - (crosshairImage.height * crosshairScale / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width * crosshairScale, crosshairImage.height * crosshairScale), crosshairImage);
    }
}
