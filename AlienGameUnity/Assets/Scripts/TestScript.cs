using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //adding debug text
        Debug.Log("Hello world!");
        Debug.Log("I am to tired for this");
        Debug.Log("I'm gunna put Darren in the microwave");
        Debug.Log("Im not kidding");

        //moving character
        transform.Translate(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello world!");
        //continuously moving char
        transform.Translate(1, 1, 1);
    }
}
