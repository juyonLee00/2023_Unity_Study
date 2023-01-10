using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("Bumped into a wall");
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}

/*
callback - 정의하면 유니티가 적절한 때에 자동으로 호출해주는 것 
Console - [Collapse] 켜두면 동일한 정보의 출력은 겹쳐서 숫자만 올라감 

MeshRenderer는 우리 눈에 보이는 그래픽?임
GetComponent<> - 오브젝트에 부착된 component를 가져옴 
*/
