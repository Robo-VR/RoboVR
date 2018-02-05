using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectControl : MonoBehaviour
{
    public GameObject nomalEnemy;

    public GameObject induceEnemy;

    private GameObject prb;

	void Start ()
    {

    }

	void Update ()
    {
		
	}

    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Enemy")
    //    {
    //        Destroy(nomalEnemy);
    //        Destroy(induceEnemy);
    //    }
    //}

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("爆発");
            //Destroy(nomalEnemy);
            //Destroy(induceEnemy);
        }
    }
}
