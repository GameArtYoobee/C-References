using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    private int EnemyDistance = 0;
    private int enemyCount = 10;

    private string[]enemiesList = new string[7];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp("space"))
        {
           //nemySearch();
            // EnemyDestruction();
            // EnemyScan();
            EnemiesRoaster();

        }
    }

    //For Loops
    void EnemySearch ()
    {
        for(int i = 0; i < 5; i ++ )
        {
            EnemyDistance = Random.Range(1, 10);
            if(EnemyDistance >= 9)
            {
                print("Enemy is far away!");
            }
            if (EnemyDistance >= 4 && EnemyDistance <=7)
            {
                print("Enemy is at a medium range!");
            }
            if (EnemyDistance < 4)
            {
                print("Enemy is very close by!");
            }
        }
    }

    //While Loops
    void EnemyDestruction()
    {
        while (enemyCount > 0)
        {
            print("There is an enemy! Lets Destroy it!");
            enemyCount--;

        }

    }

    //Do while Loops
    void EnemyScan()
     {
     bool isAlive = false;
     do
     {
     print("Scanning for enemies!");
     }
     while (isAlive == true);
     }
     
    void EnemiesRoaster()
    {
        enemiesList[0] = "Test00";
        enemiesList[1] = "Test01";
        enemiesList[2] = "Test02";
        enemiesList[3] = "Test03";
        enemiesList[4] = "Test04";
        enemiesList[5] = "Test05";
        enemiesList[6] = "Test06";

        foreach(string enemyList in enemiesList)
        {
            print(enemyList);
        }
       
     }
}
