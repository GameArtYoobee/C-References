using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public float rotateSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        // rotateSpeed = 10.0f; 
        
    }

    // Update is called once per frame
    void Update()
    {

        //print(Input.GetAxis("Horizontal"));
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical"));
    }
}
