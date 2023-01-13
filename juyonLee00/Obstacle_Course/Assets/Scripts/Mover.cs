using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //Inspector에서 변수값 실시간 변경 가능. 그러나 Inspector변수값이 실제 변수값에 오버라이딩 되지는 않음.
    [SerializeField] float xValue;
    [SerializeField] float yValue;
    [SerializeField] float zValue;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
