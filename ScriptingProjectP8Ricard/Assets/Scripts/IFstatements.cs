using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFstatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest ()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("AHHHH. What the, this coffee is way too hot. I'm NOT drinking this.");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Huh, this coffee is cold, yeah I'm not drinking this.");
        }
        else
        {
            print("This coffee is perfect, just perfect.");
        }
    }
}
