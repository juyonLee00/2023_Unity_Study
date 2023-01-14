using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
        
    }
}

/*
Problem to solve: 3초마다 물체가 플레이어 위로 떨어지도록 함

Solution:
1. A timer - Time.time  // 게임 경과 시간을 알려줌, 단위는 초 
2. A mechanism to "do a thing if 3 seconds has elapsed" - if()
3. A way to start the object falling after 3 seconds - disable / enable gravity

- 의미가 있거나 변경해야하는 값이라면 변수로 만들기

caching 
자주 사용되는 데이터나 정보를 필요할 때 쉽게 접근할 수 있도록 메모리에 저장하는 것 // 11줄 
*/
