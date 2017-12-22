using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour
{
    public GameObject Target;

    public GameObject ExplosionEffect;

    NavMeshAgent agent;

    // Use this for initialization
    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.destination = Target.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ExplosionEffect = (GameObject)Instantiate(ExplosionEffect,transform.position, Quaternion.identity);
            Destroy(ExplosionEffect, 1.2f);
        }
    }

}
