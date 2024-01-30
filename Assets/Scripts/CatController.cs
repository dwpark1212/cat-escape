using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    // point 1.Cat의 움직임에 관여하는 Rigidbody2D에 연결해준다.
    [SerializeField] private float force = 680f;
    void Update()
    {
        // 점프. 힘을가하자 
        // point 2.GetKeyDown(Keycode.xxx) 활용하기
        // point 3.AddForce를 사용
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spacebar 눌렀을때 위 방향으로 움직인다.
            this.rbody.AddForce(this.transform.up * this.force);
            //this.rbody.AddForce(Vector3.up * this.force);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 왼쪽 방향키를 눌렀을때 왼쪽방향으로 움직인다.
            this.rbody.AddForce(-this.transform.right * 150f);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 오른쪽 방향키를 눌렀을때 오른쪽방향으로 움직인다.
            this.rbody.AddForce(this.transform.right * 150f);
        }
        else
        {
            // 아무것도 누르지 않았을때 움직이지 않는다.
            this.rbody.AddForce(this.rbody.transform.up * 0f);
        }
    }
}
