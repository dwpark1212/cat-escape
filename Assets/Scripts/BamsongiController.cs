using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    // 움직이기 위해서는 먼저 Rigidbody를 알고있어야한다.
    // ParticleSystem 시스템을 사용하기 위해서
    private ParticleSystem particleSystem;
    private Rigidbody rb;
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        this.particleSystem = this.GetComponent<ParticleSystem>();
        this.Shoot();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.LogFormat("OncollisionEnter : {0}",collision.gameObject.name);
        this.rb.isKinematic = true;

        // 파티클시스템 컴포넌트 접근해서 play메서드 호출
        this.particleSystem.Play();
    }
    void Shoot()
    {
        this.rb.AddForce(new Vector3(0, 0, 2000));
    }

   
}
