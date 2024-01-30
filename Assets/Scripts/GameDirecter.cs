using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // point 1. Text�� ����Ϸ��� ����Ѵ�.

public class GameDirecter : MonoBehaviour
{
    private GameObject carGo;   // ���ӿ�����Ʈ�� car�� �����ϱ�
    private GameObject flagGO;  // ���ӿ�����Ʈ�� flag�� �����ϱ�
    private GameObject distanceGo;  // ���ӿ�����Ʈ�� distance�� �����ϱ�
    private Text distanceText;  // ���ӿ�����Ʈ�� distance�� text�� �����ϱ�
    void Start()
    {
        // point 2. Find�� ����Ͽ� ���ӿ�����Ʈ�� ã���� �ִ�.
        this.carGo = GameObject.Find("car");    // ���ӿ�����Ʈ�� car�� ã�´�.
        Debug.LogFormat("this.carGo: {0}", this.carGo);  //car ���ӿ�����Ʈ �ν��Ͻ�
        this.flagGO = GameObject.Find("flag");  // ���ӿ�����Ʈ�� flag�� ã�´�.
        Debug.LogFormat("this.flagGo: {0}", this.flagGO);   //flag ���ӿ�����Ʈ �ν��Ͻ�
        this.distanceGo = GameObject.Find("distance");  // ���ӿ�����Ʈ�� distance�� ã�´�.
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);   //distance ���ӿ�����Ʈ �ν��Ͻ�

        // point 3. GetComponent< >�� ����Ͽ� ������ ������ҿ� ���� ������ �����ü��ִ�.
        distanceText = distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);
    }

    void Update()
    {
        // �������Ӹ��� �ڵ����� ����� �Ÿ��� ���
        float length = this.flagGO.transform.position.x - this.carGo.transform.position.x;
        Debug.Log(length);
        distanceText.text = length.ToString("�����Ÿ� :0.00") + "m";
    }
    
}
