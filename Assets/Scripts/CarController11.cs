using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarController11 : MonoBehaviour
{
    [SerializeField] Transform flagtransform;
    private float length;
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                this.transform.Translate(transform.right * 1f * Time.deltaTime);
                float length = flagtransform.position.x - this.transform.position.x;
                Debug.Log(length);
                Debug.Log("�̵����Դϴ�.");
                //if (length < 1)
                //{
                    
                //}��� ���ư����ϱ�
            }
            
     }
}
