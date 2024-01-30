using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NinjaStarController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Vector3 StartPoint;
    [SerializeField] private float NinjaStarSpeed;
    void Update()
    {
        // 화면을 터치했을때 표창이 회전한다.
        if(Input.GetMouseButton(0))
        {
            this.transform.Rotate(0,0,speed);
        }
        // 화면을 터치한 지점 나타내기.
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            StartPoint = Input.mousePosition;
        }
        // 화면에서 손을뗀 지점 및 y축의 거리 차이 나타내기
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log(Input.mousePosition);
            float length = Input.mousePosition.y - StartPoint.y;
            Debug.Log(length);
            NinjaStarSpeed = length / 500f;
            this.transform.Translate(Vector3.up * Time.deltaTime, 0);
        }
    }
}
