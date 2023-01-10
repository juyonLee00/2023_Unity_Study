using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0;

    void Start()
    {    

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}


// [SerializeField]
// 인스펙터 값을 변경해도 스크립트의 값이 변경되지 않는다.
