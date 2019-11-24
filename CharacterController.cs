using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    /*
    int Score = 100;
    float position = 3.5f;
    char Character = 'C';
    string Words = "C";
    Bool = true/false;
    */

    /*
     Arithmatic Opperators: They are mainly used to manipulate an object, data objects in various ways.
     ++ = Increases by 1 value
     + = Adds two objects
     -- = Decreases by 1 value
     - = Substraction from the second object to first
     * = Multiply
     / = Divide
     % = Module
     = = equal
     
     Relational Operators : They are mainly used in a specific relationshiop to test between two objects. If the test is pass then its true otherwise false.
        == = Equals and reurns true to the value
        != = Not equals
        > = Greater than
        < = less than
        >= greater than or equal to
        <= lesser than or equal to

    Logical operators: used mainly to test multiple conditional operators
        && = And
        || = or
        ! = not
       */

    public float speed = 0.0f;
    public float distance = 100.0f;
    public float time = 20.0f;
    public float MaxSpeedLimit = 100.0f;
    public float MinSpeedLimit = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            SpeedCheck();
    }

    void SpeedCheck()
    {
        speed = distance / time;

        if (speed > 100 || speed < 45)
        {
            print("you are breaking the law!");
        }
        print("you're travelling at " + speed + "KMH");
    }
}
