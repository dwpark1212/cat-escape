using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeReference] private Rigidbody2D rbody;
    [SerializeField] private float force = 680f;
    // Update is called once per frame
    void Update()
    {
        // 점프. 힘을가하자 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.rbody.AddForce(this.transform.up * this.force);
            //this.rbody.AddForce(Vector3.up * this.force);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rbody.AddForce(-this.transform.right * 150f);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rbody.AddForce(this.transform.right * 150f);
        }
        else
        {
            this.rbody.AddForce(this.rbody.transform.up * 0f);
        }
    }
}
