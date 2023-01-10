using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;
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
Game - Stats - FPS 확인 
FPS: 초당 프레임 수, 컴퓨터 사양마다 FPS가 달라서 컴퓨터에 따라 Update()함수 실행 횟수도 달라지는 문제 
Time.deltaTime(각 프레임이 실행된 시간을 알려줌) 사용해 FPS로부터 독립시킴
*/