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
개체들끼리 서로 부딪히려면 rigid body라는 것을 추가해야 함 
rigid body - 개체에 질량 부여 

부딪혀서 뒤로 밀어냄 (작용-반작용?)
Freeze Position / Rotation 설정 

구석에 틈이 좀 있으면 벽을 뚫고 나갈 수 있음 - 나중에 ㄱ 
(# 모양으로 만들었는데도 구석에서 뚫고 나가네..뭐지)
*/