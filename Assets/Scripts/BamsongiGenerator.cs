using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BamsongiGenerator : MonoBehaviour
{
    [SerializeField] GameObject bamsongi;
    [SerializeField] GameObject target;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bamsongi);
            Debug.Log(Input.mousePosition);
            Vector3 Startpoint = this.transform.position;
            Debug.Log(Startpoint);
            float length = target.transform.position.z - Startpoint.z;
            Debug.Log(length);

        }

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Vector3 worldDir = ray.direction;

    }
}
