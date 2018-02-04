using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RDirectionCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        // 十字キーで首を左右上下に回す
        if (Input.GetKey(KeyCode.H))
        {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f));
        }
    }
}
