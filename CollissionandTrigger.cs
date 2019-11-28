using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionandTrigger : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "has Entered!");
         }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + "has Existed!");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + "has Stayed!");
    }

    
}
