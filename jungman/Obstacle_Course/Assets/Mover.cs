using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //현재 위치에 값을 더하기  transform.Translate()
        
    }

    // Update is called once per frame
    void Update()
    {
        // unity에서는 float로 작동 
        transform.Translate(0.01f, 0, 0);
    }
}
