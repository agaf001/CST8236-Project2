using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {


    public int rotSpeed = 100;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rotSpeed += 50;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rotSpeed -= 50;
        }


        Rotate();
    }

    void Rotate()
    {
        transform.Rotate(Vector3.down * Time.deltaTime * rotSpeed, Space.World);
    }
}
