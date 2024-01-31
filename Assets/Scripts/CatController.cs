using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;  // 클리어씬사용하려면 추가해줘야함

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    // point 1.Cat의 움직임에 관여하는 Rigidbody2D에 연결해준다.
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
        // 점프. 힘을가하자 ( -1, 0, 1 ) : 방향
        // point 2.GetKeyDown(Keycode.xxx) 활용하기
        // point 3.AddForce를 사용

        bool a = (rbody.velocity.y == 0) == true;
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if(a == true)
            {
                this.rbody.AddForce(this.transform.up * this.jumpforce);
            }
            // Spacebar 눌렀을때 위 방향으로 움직인다.
            
            //this.rbody.AddForce(Vector3.up * this.force);
        }
        int dirX = 0;
        if(Input.GetKey(KeyCode.LeftArrow)) // 왼쪽 화살표키를 누르고 있는 동안에//this.rbody.AddForce(-this.transform.right * 150f);
        {
            dirX = -1;
        }
        if(Input.GetKey(KeyCode.RightArrow)) // 오른쪽 방향키를 눌렀을때 오른쪽방향으로 움직인다.//this.rbody.AddForce(this.transform.right * 150f);
        {
            dirX = 1;
        }
        
        //Debug.Log(dirX); //방향 -1, 0 , 1
        //스케일 x를 변경하는데 키가 눌렀을때만
        // 키가 눌렀을때만 = (dirX != 0)
        if (dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }
        
        // 벡터의 곱
        //Debug.Log(this.transform.right * dirX);  //벡터3

        //point . Mathf.Abs는 절대값 넣어줄때 사용
        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveforce);
        }
        this.anim.speed = (this.rbody.velocity.x);
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);
        // 화면밖으로 안나가게 해주는 코드 *************************************확인하기****************)
        Vector3 localposition = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.4f), transform.position.y, transform.position.z);
        transform.position = localposition;

    }
    //Trigger모드일경우 충돌 판정을 해주는 이벤트 함수
    int collisioncount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //최초 충돌할때 한번만
        if(collisioncount < 1)
        {
            Debug.LogFormat("OnTriggerEnter2D: {0}", collision);
            collisioncount++;
        }
        
        //장면 전환
        SceneManager.LoadScene("ClimbCloudClear");
        
            
        //터치했을때 장면전환
        if(Input.GetMouseButtonDown(0))
        {

        }
    }
    
}
