//--------------------------------------------------------------------------------------------------
// @file	InduceEnemy.cs
// @brief	InduceEnemyの実装
// @author	matsuda
//--------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InduceEnemy : MonoBehaviour
{
    public GameObject Target;

    public GameObject Enemy;

    public GameObject ExplosionEffect;

    private float ShortSqrDistance = 25f;

    NavMeshAgent agent;


    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();agent.destination = Target.transform.position;
    }
	

	void Update ()
    {
        float sqrDistance = Vector3.SqrMagnitude(transform.position - Target.transform.position);

        Debug.Log(sqrDistance);

        if (sqrDistance < ShortSqrDistance)
        {
            //agent.Stop();
        }

        if(Input.GetKey(KeyCode.Space))
        {
            ExplosionEffect = (GameObject)Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            Destroy(ExplosionEffect, 1.2f);
            Destroy(Enemy);
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ExplosionEffect = (GameObject)Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            Destroy(ExplosionEffect, 1.2f);
            Destroy(Enemy);
        }
    }


}
