using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBurst : MonoBehaviour
{
    public float ballVelocity = 100.0f;
    public Rigidbody rb;
    private bool ballInPlay;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new vector3(ballVelocity, ballVelocity, 0.0f));
        }
    }
}
