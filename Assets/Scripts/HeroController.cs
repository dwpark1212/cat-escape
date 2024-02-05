using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private int maxHp = 10;
    private int hp;
    void Start()
    {
        this.hp = this.maxHp;
        Debug.LogFormat("{0}/{1}", this.hp, this.maxHp);
    }

    // Update is called once per frame
    void Update()
    {
        //화면을 클릭하면 피해를 받는다.
        if(Input.GetMouseButtonDown(0))
        {
            this.hp -= 1;
            if(this.hp <= 0) this.hp = 0;
            //Debug.LogFormat()
        }
    }
}
