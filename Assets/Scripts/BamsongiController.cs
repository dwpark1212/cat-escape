using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    // �����̱� ���ؼ��� ���� Rigidbody�� �˰��־���Ѵ�.
    // ParticleSystem �ý����� ����ϱ� ���ؼ�
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

        // ��ƼŬ�ý��� ������Ʈ �����ؼ� play�޼��� ȣ��
        this.particleSystem.Play();
    }
    void Shoot()
    {
        this.rb.AddForce(new Vector3(0, 0, 2000));
    }

   
}
