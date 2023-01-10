using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0;
    float yValue = 0.01f;
    float zValue = 0;

    void Start()
    {    
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}


// 변수로 값을 관리할 수 있음 