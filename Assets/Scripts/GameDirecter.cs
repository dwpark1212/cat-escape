using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // point 1. Text를 사용하려면 써야한다.

public class GameDirecter : MonoBehaviour
{
    private GameObject carGo;   // 게임오브젝트의 car에 연결하기
    private GameObject flagGO;  // 게임오브젝트의 flag에 연결하기
    private GameObject distanceGo;  // 게임오브젝트의 distance에 연결하기
    private Text distanceText;  // 게임오브젝트의 distance의 text에 연결하기
    void Start()
    {
        // point 2. Find를 사용하여 게임오브젝트를 찾을수 있다.
        this.carGo = GameObject.Find("car");    // 게임오브젝트의 car를 찾는다.
        Debug.LogFormat("this.carGo: {0}", this.carGo);  //car 게임오브젝트 인스턴스
        this.flagGO = GameObject.Find("flag");  // 게임오브젝트의 flag를 찾는다.
        Debug.LogFormat("this.flagGo: {0}", this.flagGO);   //flag 게임오브젝트 인스턴스
        this.distanceGo = GameObject.Find("distance");  // 게임오브젝트의 distance를 찾는다.
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);   //distance 게임오브젝트 인스턴스

        // point 3. GetComponent< >를 사용하여 유형의 구성요소에 대한 참조를 가져올수있다.
        distanceText = distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);
    }

    void Update()
    {
        // 매프레임마다 자동차와 깃발의 거리를 계산
        float length = this.flagGO.transform.position.x - this.carGo.transform.position.x;
        Debug.Log(length);
        distanceText.text = length.ToString("남은거리 :0.00") + "m";
    }
    
}
