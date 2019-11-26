using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemies : MonoBehaviour
{
    //public Collider;
    public GameObject[] enemies;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            EnemySearch();
    }

    void EnemySearch()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < enemies.Length; i++)
        {
            print("Enemy Number: " + i + " is named " + enemies[i].name);
        }
    }
}
