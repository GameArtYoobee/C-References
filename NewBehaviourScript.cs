using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform startingPoint;
    void Update()
    {

    }
       
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(player);
        player.transform.position = startingPoint.transform.position;
    }
}