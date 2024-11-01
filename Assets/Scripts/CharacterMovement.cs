using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5; 
    public Rigidbody rigidbody;

    float horizontalInput;
    public float horizontalMultiplier = 2; 

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 

        if (transform.position.x > 4.34f)
        {
            transform.position = new Vector3(4.34f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -4f)
        {
            transform.position = new Vector3(-4f, transform.position.y, transform.position.z);
        }
    }

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rigidbody.MovePosition(rigidbody.position + forwardMove + horizontalMove); 
    }
}
