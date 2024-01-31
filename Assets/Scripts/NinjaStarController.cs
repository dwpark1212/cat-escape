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
        // ȭ���� ��ġ�������� ���� ��Ÿ����
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            StartPoint = Input.mousePosition;
        }           
        // ȭ�鿡�� ������ ���� �� y���� �Ÿ� ���� ��Ÿ����
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log(Input.mousePosition);
            // y���� �Ÿ����̸� �̿��Ͽ� ���ǵ带 ���Ѵ�(���⼭ ���� ũ�⶧���� ������ ���ڷ� �������ش�)
            length = ((Input.mousePosition.y - StartPoint.y) / 500f);
            this.transform.Translate(Vector3.up * Time.deltaTime, 0);
        }
    }
}
