using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    // Create a variable of type integer
    int MyInt = 3;


    // Start is called before the first frame update
    void Start()
    {
        // Im going to run MyInt through my function to multiply it by two
        MyInt = MultiplyByTwo(MyInt);
        Debug.Log(MyInt);
    }


    // Update is called once per frame
    void Update()
    {
        
    }



    int MultiplyByTwo(int number)
    {
        int results;
        results = number * 2;
        return results;
    }
}
