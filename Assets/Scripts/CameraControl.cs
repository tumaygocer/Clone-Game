using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float smootSpeed;
    void Start()
    {
        offset = transform.position - ball.transform.position;
    }

   
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position, smootSpeed);
        transform.position = newPos;
    }
}
