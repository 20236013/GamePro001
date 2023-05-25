using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject Enemy_prefab;


    void Start()
    {
        this.Enemy_prefab = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);

        if(transform.position.y< 1.0f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        Vector2 p2 = this.Enemy_prefab.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d< r1 + r2)
        {
            Destroy(gameObject); 
        }
    }
}
