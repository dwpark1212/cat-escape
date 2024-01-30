using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameDirecter : MonoBehaviour
{
    private GameObject carGo;
    private GameObject flagGO;
    private GameObject distanceGo;
    private GameObject distanceText;
    void Start()
    {
        this.carGo = GameObject.Find("car");
        Debug.LogFormat("this.carGo: {0}", this.carGo);  //car ���ӿ�����Ʈ �ν��Ͻ�
        this.flagGO = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo: {0}", this.flagGO);   //flag ���ӿ�����Ʈ �ν��Ͻ�
        this.distanceGo = GameObject.Find("distance");
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);   //distance ���ӿ�����Ʈ �ν��Ͻ�
        this.distanceText = GameObject.Find("text");
        Debug.LogFormat("this.distanceText: {0}", this.distanceText);

        Text distanceText = this.distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);
        distanceText.text = "�ȳ��ϼ���";
    }

    void Update()
    {
        // �������Ӹ��� �ڵ����� ����� �Ÿ��� ���
        float length = this.flagGO.transform.position.x - this.carGo.transform.position.x;
        Debug.Log(length);
    }
}
