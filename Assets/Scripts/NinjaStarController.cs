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
        // ȭ���� ��ġ������ ǥâ�� ȸ���Ѵ�.
        if(Input.GetMouseButton(0))
        {
            this.transform.Rotate(0,0,speed);
        }
        // ȭ���� ��ġ�� ���� ��Ÿ����.
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            StartPoint = Input.mousePosition;
        }
        // ȭ�鿡�� ������ ���� �� y���� �Ÿ� ���� ��Ÿ����
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
