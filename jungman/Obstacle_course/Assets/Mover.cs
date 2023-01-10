using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7.0f;
    void Start()
    {    

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; 
        transform.Translate(xValue, 0, zValue);
    }
}


/*
-Window - package manager - cinemachine  - Unity registry - cinemachine 패키지 설치
-Add Cinemachine Brain component to camera 
-Add virtual Camera
-Rename Virtual Camera 
  follow - follow 
  Look at - cctv 
-Tune distance 
*/