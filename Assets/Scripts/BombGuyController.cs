using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class BombGuyController : MonoBehaviour
{
    //bombguycontroller가 animator 컴포넌트를 알아야한다.
    // 왜? 애니메이션 전환을 해야하니까
    //animator컴포넌트는 자식오브젝트  anim에 붙어있다.
    //어떻게하면 자식오브젝트에 붙어있는 animator컴포넌트를 가져올수 있을까?
    [SerializeField] Transform flagtransform;
    [SerializeField] private Animator anim;
    private float Speed = 0.1f;
    private Coroutine coroutine;
    
    private void Start()
    {
        Debug.Log("Start");
        //Transform animTransform = this.transform.Find("anim");
        //GameObject animGo = animTransform.gameObject;
        //코루틴 함수 호출시
        //Debug.LogFormat("coroutine: {0}", this.coroutine);
        this.coroutine = this.StartCoroutine(this.CoMove());
        
    }
    int dirX = 0;
    IEnumerator CoMove()
    {
        while (true)
        {
            this.transform.Translate(transform.right * 1f * Time.deltaTime);
            float length = this.flagtransform.position.x - this.transform.position.x;
            Debug.LogFormat("이동중...남은거리: {0}",length);
            if(length < 1)
            {
                break;
            }
            yield return null;  //다음 프레임으로 넘어간다.
        }
        Debug.Log("이동완료");
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StopCoroutine(this.coroutine);
        }
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Translate(-Speed, 0, 0);
        //    this.anim.SetInteger("State", 1);
        //    // 이동하는 방향 바라보기만들기
        //}
        //if(Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(Speed, 0, 0);
        //    this.anim.SetInteger("State", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha0))
        //{
        //    Debug.Log("Idle");
        //    // 애니메이션 전환하기
        //    // 전환할때 파라미터에 값을 변경하기
        //    this.anim.SetInteger("State", 0);
        //}
        //if(Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    Debug.Log("Run");
        //    this.anim.SetInteger("State", 1);

        //}
    }
}
