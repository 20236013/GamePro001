using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyaractormobe : MonoBehaviour
{
   
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }





    }
}
