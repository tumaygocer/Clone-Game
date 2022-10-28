using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public float jumpForce;
    public GameObject splashParticle;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cylinder"))
        {
            Instantiate(splashParticle, transform.position, transform.rotation);
            _rigidbody.AddForce(Vector3.up * jumpForce);
        }
        else
        {
            Debug.Log("Game Over");
        }
       
       
    }
}
