using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// LineRenderer によるレーザーポインタ

public class LaserPointer : MonoBehaviour
{
    public GameObject player;
    LineRenderer laser;

    void Start()
    {
        laser = this.GetComponent<LineRenderer>();
        laser.SetPosition(1, player.transform.forward * 100);
    }
}
