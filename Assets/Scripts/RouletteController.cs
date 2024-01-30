using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class RouletteController : MonoBehaviour
{   
    [SerializeField] private float maxSpeed = 7;
    [SerializeField] private float speed = 0;
    [SerializeField] private float attenuation = 0.99f;
    //1. ���콺 ���� Ŭ���� �ϸ�
    //2. ȸ���Ѵ�
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Button Down");
            speed = maxSpeed;
        }

        this.transform.Rotate(0, 0, speed);

        speed *= attenuation;
    }
}
