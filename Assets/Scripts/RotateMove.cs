using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    public float rotateSpeed;
    private float moveX;
   

  
    void Update()
    {
        if (Input.touchCount == 0) return;
        HandleInput();
    }
    void HandleInput()
    {
        Touch finger = Input.GetTouch(0);

        if (finger.deltaPosition.x > 60.0f && finger.deltaPosition.x < -60.0f)
        {
            transform.Rotate(0f, moveX * rotateSpeed * Time.deltaTime, 0f);
        }

       
    }

}
