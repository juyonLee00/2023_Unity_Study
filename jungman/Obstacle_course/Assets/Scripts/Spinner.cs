using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0.1f;
    [SerializeField] float zAngle = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}

// Rotate() 이전 값에 더해서 회전시키기 