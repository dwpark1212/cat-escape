using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;  // Ŭ���������Ϸ��� �߰��������

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    // point 1.Cat�� �����ӿ� �����ϴ� Rigidbody2D�� �������ش�.
    [SerializeField] private float jumpforce = 500f;
    [SerializeField] private float moveforce = 100f;
    [SerializeField] private ClimbCloudGameDirector gameDirector;

    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    
      
    void Update()
    {
        // ����. ���������� ( -1, 0, 1 ) : ����
        // point 2.GetKeyDown(Keycode.xxx) Ȱ���ϱ�
        // point 3.AddForce�� ���

        bool a = (rbody.velocity.y == 0) == true;
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if(a == true)
            {
                this.rbody.AddForce(this.transform.up * this.jumpforce);
            }
            // Spacebar �������� �� �������� �����δ�.
            
            //this.rbody.AddForce(Vector3.up * this.force);
        }
        int dirX = 0;
        if(Input.GetKey(KeyCode.LeftArrow)) // ���� ȭ��ǥŰ�� ������ �ִ� ���ȿ�//this.rbody.AddForce(-this.transform.right * 150f);
        {
            dirX = -1;
        }
        if(Input.GetKey(KeyCode.RightArrow)) // ������ ����Ű�� �������� �����ʹ������� �����δ�.//this.rbody.AddForce(this.transform.right * 150f);
        {
            dirX = 1;
        }
        
        //Debug.Log(dirX); //���� -1, 0 , 1
        //������ x�� �����ϴµ� Ű�� ����������
        // Ű�� ���������� = (dirX != 0)
        if (dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }
        
        // ������ ��
        //Debug.Log(this.transform.right * dirX);  //����3

        //point . Mathf.Abs�� ���밪 �־��ٶ� ���
        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveforce);
        }
        this.anim.speed = (this.rbody.velocity.x);
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);
        // ȭ������� �ȳ����� ���ִ� �ڵ� *************************************Ȯ���ϱ�****************)
        Vector3 localposition = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.4f), transform.position.y, transform.position.z);
        transform.position = localposition;

    }
    //Trigger����ϰ�� �浹 ������ ���ִ� �̺�Ʈ �Լ�
    int collisioncount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���� �浹�Ҷ� �ѹ���
        if(collisioncount < 1)
        {
            Debug.LogFormat("OnTriggerEnter2D: {0}", collision);
            collisioncount++;
        }
        
        //��� ��ȯ
        SceneManager.LoadScene("ClimbCloudClear");
        
            
        //��ġ������ �����ȯ
        if(Input.GetMouseButtonDown(0))
        {

        }
    }
    
}
