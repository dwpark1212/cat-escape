using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    // point 1.Cat�� �����ӿ� �����ϴ� Rigidbody2D�� �������ش�.
    [SerializeField] private float force = 680f;
    void Update()
    {
        // ����. ���������� 
        // point 2.GetKeyDown(Keycode.xxx) Ȱ���ϱ�
        // point 3.AddForce�� ���
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spacebar �������� �� �������� �����δ�.
            this.rbody.AddForce(this.transform.up * this.force);
            //this.rbody.AddForce(Vector3.up * this.force);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // ���� ����Ű�� �������� ���ʹ������� �����δ�.
            this.rbody.AddForce(-this.transform.right * 150f);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            // ������ ����Ű�� �������� �����ʹ������� �����δ�.
            this.rbody.AddForce(this.transform.right * 150f);
        }
        else
        {
            // �ƹ��͵� ������ �ʾ����� �������� �ʴ´�.
            this.rbody.AddForce(this.rbody.transform.up * 0f);
        }
    }
}
