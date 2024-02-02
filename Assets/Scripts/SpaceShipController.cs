using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbody;
    private float speed = 10f;
    void Start()
    {
        float move = Input.GetAxis("Horizontal");
        this.rbody.transform.Translate(move, speed, 1);

    }
}
