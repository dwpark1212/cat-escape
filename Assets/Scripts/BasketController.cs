using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private AudioClip appleSfx;
    [SerializeField] private AudioClip bombSfx;
    private AudioSource audioSource;

    private void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
    }
    void Update()
    {
        //화면을 터치하면 터치한 위치로 바스킷을 움직인다

        //화면을 터치하면
        if(Input.GetMouseButtonDown(0))
        {
            //ray를 만든다
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //지역변수 RaycastHit hit 정의
            RaycastHit hit;

            //if문 작성
            if(Physics.Raycast(ray.origin, ray.direction,out hit,20f))
            {
                //레이와 콜라이더가 충돌 했다면 바구니의 위치를 움직인다.
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(x, 0, z);
        
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("잡았다! = > {0}", other.gameObject.tag);

        if(other.gameObject.tag == "Apple")
        {
            Debug.Log("득점");
            this.audioSource.PlayOneShot(this.appleSfx);
        }
        else if(other.gameObject.tag == "Bomb")
        {
            Debug.Log("감점");
            this.audioSource.PlayOneShot(this.bombSfx);
        }
        Destroy(other.gameObject);
    }
}
