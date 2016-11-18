using UnityEngine;
using System.Collections;

public class Skin : MonoBehaviour {


 //   public Material materialToChangeTo;

    public Material[] materials = new Material[6];

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            //materialToChangeTo.SetTexture("_Texture", textures[0]);
            renderer.material = materials[0];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            //materialToChangeTo.SetTexture("_Texture", textures[0]);
            renderer.material = materials[1];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            //materialToChangeTo.SetTexture("_Texture", textures[0]);
            renderer.material = materials[2];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            //materialToChangeTo.SetTexture("_Texture", textures[0]);
            renderer.material = materials[3];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            //materialToChangeTo.SetTexture("_Texture", textures[0]);
            renderer.material = materials[4];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            //materialToChangeTo.SetTexture("_Texture", textures[0]);
            renderer.material = materials[5];
        }
    }

   /* void LoadTextures()
    {
        textures[0] = (Texture3D)Resources.Load("");
    }
    */

}
