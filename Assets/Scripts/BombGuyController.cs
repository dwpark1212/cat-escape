using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class BombGuyController : MonoBehaviour
{
    //bombguycontroller�� animator ������Ʈ�� �˾ƾ��Ѵ�.
    // ��? �ִϸ��̼� ��ȯ�� �ؾ��ϴϱ�
    //animator������Ʈ�� �ڽĿ�����Ʈ  anim�� �پ��ִ�.
    //����ϸ� �ڽĿ�����Ʈ�� �پ��ִ� animator������Ʈ�� �����ü� ������?
    [SerializeField] Transform flagtransform;
    [SerializeField] private Animator anim;
    private float Speed = 0.1f;
    private Coroutine coroutine;
    
    private void Start()
    {
        Debug.Log("Start");
        //Transform animTransform = this.transform.Find("anim");
        //GameObject animGo = animTransform.gameObject;
        //�ڷ�ƾ �Լ� ȣ���
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
            Debug.LogFormat("�̵���...�����Ÿ�: {0}",length);
            if(length < 1)
            {
                break;
            }
            yield return null;  //���� ���������� �Ѿ��.
        }
        Debug.Log("�̵��Ϸ�");
        
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
        //    // �̵��ϴ� ���� �ٶ󺸱⸸���
        //}
        //if(Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(Speed, 0, 0);
        //    this.anim.SetInteger("State", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha0))
        //{
        //    Debug.Log("Idle");
        //    // �ִϸ��̼� ��ȯ�ϱ�
        //    // ��ȯ�Ҷ� �Ķ���Ϳ� ���� �����ϱ�
        //    this.anim.SetInteger("State", 0);
        //}
        //if(Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    Debug.Log("Run");
        //    this.anim.SetInteger("State", 1);

        //}
    }
}
