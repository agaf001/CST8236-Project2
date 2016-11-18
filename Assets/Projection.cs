using UnityEngine;
using System.Collections;


public class Projection : MonoBehaviour {

    // Use this for initialization
    //public static GameObject cameraObj = GameObject.FindWithTag("MainCamera");
    //public Camera camera = (Camera)cameraObj.GetComponent(typeof(Camera));
    //public GameObject other;


    //Initialized in the Ispector
    public Camera camera;
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (camera.orthographic == true)
                camera.orthographic = false;
            else
                camera.orthographic = true;
        }
    }
}
