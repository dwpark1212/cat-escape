using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NinjaStarController : MonoBehaviour
{
    [SerializeField] private float length;
    [SerializeField] private Vector3 StartPoint;
    [SerializeField] private float NinjaStarSpeed;
    void Update()
    {
        // 화면을 터치했을때의 지점 나타내기
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            StartPoint = Input.mousePosition;
        }           
        // 화면에서 손을뗀 지점 및 y축의 거리 차이 나타내기
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log(Input.mousePosition);
            // y축의 거리차이를 이용하여 스피드를 구한다(여기서 값이 크기때문에 임의의 숫자로 나누어준다)
            length = ((Input.mousePosition.y - StartPoint.y) / 500f);
            this.transform.Translate(Vector3.up * Time.deltaTime, 0);
        }
    }
}
