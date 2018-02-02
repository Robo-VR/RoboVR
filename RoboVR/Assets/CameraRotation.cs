using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 十字キーで首を左右に回す
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f));
        }
    }
}
