using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDirectionCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        // 十字キーで手を左右上下に回す
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f));
        }
    }
}
