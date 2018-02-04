using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RrocketPunchi : MonoBehaviour
{
    public bool Moveflg;
    public GameObject Lrocket;
    private float timer;
    private Vector3 startPosition;
    public GameObject Parent;
    GameObject isParent;

    // Use this for initialization
    void Start()
    {
        Moveflg = false;
        timer = 0.0f;
        startPosition = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        //ロケットパンチの発射処理
        timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.M) && Input.GetKey(KeyCode.P))
        {
            Moveflg = true;
            Parent.transform.parent = null;
        }

        if (Moveflg)
        {
            Lrocket.transform.rotation = this.gameObject.transform.rotation;
            transform.position += transform.forward * 30f * Time.deltaTime;
        }

        if (timer >= 7.0f)
        {
            Moveflg = false;
            transform.position = startPosition;
            transform.parent = GameObject.Find("RightHandAnchor").transform;

            timer = 0;
        }
    }
}