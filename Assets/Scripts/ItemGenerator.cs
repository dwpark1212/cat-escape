using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject apple;
    [SerializeField] GameObject bomb;
    private float delta;
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > 1)
        {
            delta = 0;
            GameObject item;
            int dice = Random.Range(1, 3);
            if (dice == 1)
            {
                item = Instantiate(apple);
            }
            else
            {
                item = Instantiate(bomb);
            }
            float x = Random.Range(-1, 1);
            float z = Random.Range(-1, 1);
            item.transform.position = new Vector3(x, 3, z);
            //Instantiate(apple);
            //Instantiate(bomb);
        }

    }
}
        

