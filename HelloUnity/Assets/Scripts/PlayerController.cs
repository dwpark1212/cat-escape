using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float radius = 1f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            this.transform.Translate(-2, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Translate(2, 0, 0);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
