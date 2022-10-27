using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public float jumpForce;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.AddForce(Vector3.up * jumpForce);
    }
}
