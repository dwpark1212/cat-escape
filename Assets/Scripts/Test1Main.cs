using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Main : MonoBehaviour
{
    [SerializeField] private Transform basketTransform;
    void Update()
    {
        
        // ȭ���� Ŭ���ϸ�
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // ���� ��ü�� �������ִ� �Ӽ�
            //ray.origin : ������ġ
            //ray.dirction : ����
                            //������ġ      ����          ����   ���ʵ��Ⱥ����ٷ�
            Debug.DrawRay(ray.origin, ray.direction*20f, Color.red, 10);

            // ���̿� �ݶ��̴� �浹 üũ

            RaycastHit hit;     //�浹�ߴٸ� �浹 ������ ��� ����
            if(Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                //���̿� �ݶ��̴��� �浹�ߴ�.
                Debug.Log("�浹��");
                Debug.LogFormat("=> {0}", hit.point); // �浹������ġ(������ġ)
                this.basketTransform.position = hit.point;
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                //Vector3 basketTransform.
            }
            //�Ǽ� ���� 1. �ݶ��̴��� ����, 2. ray�� ���̰� ª��.



        }
    }
}
