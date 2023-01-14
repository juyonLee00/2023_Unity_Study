using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //SerializeField Inspector에서 변수값 실시간 변경 가능. 그러나 Inspector변수값이 실제 변수값에 오버라이딩 되지는 않음.
    

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //Input Manager의 축값을 가져와 키에 따라 -1, +1값 적용.
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue, 0, zValue);
    }
}
