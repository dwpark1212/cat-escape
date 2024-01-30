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
        Debug.LogFormat("this.carGo: {0}", this.carGo);  //car 게임오브젝트 인스턴스
        this.flagGO = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo: {0}", this.flagGO);   //flag 게임오브젝트 인스턴스
        this.distanceGo = GameObject.Find("distance");
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);   //distance 게임오브젝트 인스턴스
        this.distanceText = GameObject.Find("text");
        Debug.LogFormat("this.distanceText: {0}", this.distanceText);

        Text distanceText = this.distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);
        distanceText.text = "안녕하세요";
    }

    void Update()
    {
        // 매프레임마다 자동차와 깃발의 거리를 계산
        float length = this.flagGO.transform.position.x - this.carGo.transform.position.x;
        Debug.Log(length);
    }
}
