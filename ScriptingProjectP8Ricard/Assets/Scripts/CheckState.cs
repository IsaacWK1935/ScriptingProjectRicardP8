using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject MyObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Activate Self: " + MyObject.activeSelf);
        Debug.Log("Activate in Hierarchy" + MyObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
