using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            gameObject.tag = "Hit";
        }
    }
}

/*
플레이어가 부딪힌 동안만 색 변하게 하기
물체는 처음 한 번 부딪힐 때만 점수 오르게 하기 
 - Tag 사용


dropper에 부딪혔는데 hits가 안오르는 문제 
아마 Unity 내부 코드 순서가 dropper에 대해 반전됐을 가능성 

원래 OnCollisionenter 메소드는 연결된 개체에 Rigidbody가 있어야 함.
근데 이제 Player와 Dropper 모두 Rigidbody를 가지고 있음 

어떤 이유로 Dropper를 추가했을 때 Rigidbody가 Player Rigidbody보다 먼저 Unity에 의해 평가되고
이는 ObjectHit 스크립트(Dropper에 부착된)의 OnCollisionEnter가 Scorer 스크립트(플레이어에 부착된)의
OnCollisionEnter보다 먼저 실행되었음을 의미.
-> 그래서 "Hit" 태그가 먼저 설정되어 Scorer 스크립트의 if 문이 실행되지 않음 
Dropper Rigidbody를 제거하고 다시 추가함으로써 Player Rigidbody 다음에 평가됩니다.
https://community.gamedev.tv/t/hitting-dropper-dosnt-add-to-hits/160796/6
*/