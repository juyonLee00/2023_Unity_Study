using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {    

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, 0, zValue);
    }
}


// Edit - Project Settings - InputManager
// 플레이어가 키보드에서 누른 horizontal 축에 대한 정보, 즉 <- or -> // a or d 
// 플레이어가 키보드에서 누른 Vertical 축에 대한 정보, 즉 위 or 아래 // w or s

// 플레이어가 y축으로 움직이지 않도록 