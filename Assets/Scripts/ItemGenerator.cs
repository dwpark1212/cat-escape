using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject apple;
    [SerializeField] GameObject bomb;
    private float delta;
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > 1)
        {
            delta = 0;
            GameObject item;    //���ӿ�����Ʈ apple, bomb
            int dice = Random.Range(1, 3);  //1 ~ 2 ���� ������
            if (dice == 1)
            {
                item = Instantiate(apple);  // 1�� �������� apple�� �����Ѵ�
            }
            else
            {
                item = Instantiate(bomb);   // �������϶� bomb�� �����Ѵ�.
            }
            float x = Random.Range(-1, 1);  // ������ x���� ����
            float z = Random.Range(-1, 1);  // ������ z���� ����
            item.transform.position = new Vector3(x, 3, z);
        }

    }
}
        

