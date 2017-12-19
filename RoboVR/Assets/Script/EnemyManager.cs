//--------------------------------------------------------------------------------------------------
// @file	EnemyManager.cs
// @brief	EnemyManagerの実装
// @author	matsuda
//--------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject NomalEnemy;

    public GameObject[] Enemys;

    public GameObject Target;

    NavMeshAgent agent;

    public int maxEnemy =5;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();

        Appear();
       
    }

    void Appear()
    {
        // 地点がなにも設定されていないときに返します
        if (Enemys.Length == 0)
        {
            return;
        }

        //agent.autoBraking = false;
        //agent.destination = Target.transform.position;

        Enemys = new GameObject[maxEnemy];

        //周期的に実行したい場合はコルーチン
        StartCoroutine(Exec());

    }


    IEnumerator Exec()
    {
        while (true)
        {
            Generate();
            yield return new WaitForSeconds(3.0f);
        }
    }

    void Generate()
    {
        for (int enemyCount = 0; enemyCount < Enemys.Length; ++enemyCount)
        {
            if (Enemys[enemyCount] == null)
            {
                //敵を作成する
                Enemys[enemyCount] = Instantiate(NomalEnemy, transform.position, transform.rotation) as GameObject;
                return;
            }
        }
    }
}
