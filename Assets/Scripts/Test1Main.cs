using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Main : MonoBehaviour
{
    [SerializeField] private Transform basketTransform;
    void Update()
    {
        
        // 화면을 클릭하면
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // 레이 객체가 가지고있는 속성
            //ray.origin : 시작위치
            //ray.dirction : 방향
                            //시작위치      방향          색상   몇초동안보여줄래
            Debug.DrawRay(ray.origin, ray.direction*20f, Color.red, 10);

            // 레이와 콜라이더 충돌 체크

            RaycastHit hit;     //충돌했다면 충돌 정보를 담는 변수
            if(Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                //레이와 콜라이더가 충돌했다.
                Debug.Log("충돌함");
                Debug.LogFormat("=> {0}", hit.point); // 충돌지점위치(월드위치)
                this.basketTransform.position = hit.point;
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                //Vector3 basketTransform.
            }
            //실수 유형 1. 콜라이더가 없음, 2. ray의 길이가 짧음.



        }
    }
}
