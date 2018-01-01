//--------------------------------------------------------------------------------------------------
// @file	EnemyManager.cs
// @brief	EnemyManagerの実装
// @author	matsuda
//--------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject NomalEnemy;

    public GameObject[] Enemys;

    public GameObject Target;

    public int maxEnemy =5;

    public int AppearTime;

    void Start ()
    {

        Appear();

    }

    void Appear()
    {
        // なにも設定されていないときに返します
        if (Enemys.Length == 0)
        {
            return;
        }

        //agent.autoBraking = false;


        Enemys = new GameObject[maxEnemy];

        //周期的に実行したい場合はコルーチン
        StartCoroutine(Exec());

    }


    IEnumerator Exec()
    {
        while (true)
        {
            Generate();
            yield return new WaitForSeconds(AppearTime);
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

    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Destroy(NomalEnemy);
    //    }
    //}
}
