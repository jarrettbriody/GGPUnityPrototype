using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class ManagerScript : MonoBehaviour {

    public Texture crosshairImage;
    public float crosshairScale = 0.1f;

	// Use this for initialization
	void Start ()
    {
        GameObject floor = GameObject.FindGameObjectWithTag("Ground");
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        GameObject[] barrier1s = GameObject.FindGameObjectsWithTag("Barrier1");
        GameObject[] barrier2s = GameObject.FindGameObjectsWithTag("Barrier2");
        GameObject ruin = GameObject.FindGameObjectWithTag("Ruin");

        using (StreamWriter writer = new StreamWriter("scene.txt"))//P(9.5, 0.6, -8.3)R(0.0, 125.6, 0.0)S(5.9, 1.3, 1.0)
        {
            writer.WriteLine(GenObjSceneInfo("Ground", floor));

            for (int i = 0; i < walls.Length; i++)
            {
                writer.WriteLine(GenObjSceneInfo("Wall", walls[i]));
            }

            for (int i = 0; i < barrier1s.Length; i++)
            {
                writer.WriteLine(GenObjSceneInfo("Barrier1", barrier1s[i]));
            }

            for (int i = 0; i < barrier2s.Length; i++)
            {
                writer.WriteLine(GenObjSceneInfo("Barrier2", barrier2s[i]));
            }

            writer.WriteLine(GenObjSceneInfo("Ruin", ruin));
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
	}

    public string GenObjSceneInfo(string name, GameObject g)
    {
        return name + " " +
                "P(" + g.transform.position.x + "," + g.transform.position.y + "," + g.transform.position.z +
                ")R(" + g.transform.rotation.eulerAngles.x + "," + g.transform.rotation.eulerAngles.y + "," + g.transform.rotation.eulerAngles.z +
                ")S(" + g.transform.localScale.x + "," + g.transform.localScale.y + "," + g.transform.localScale.z + ")";
    }

    void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crosshairImage.width * crosshairScale / 2);
        float yMin = (Screen.height / 2) - (crosshairImage.height * crosshairScale / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width * crosshairScale, crosshairImage.height * crosshairScale), crosshairImage);
    }
}
