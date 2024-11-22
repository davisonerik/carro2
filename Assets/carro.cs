using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carro : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 5f; 

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = moveDirection;

        if(horizontalInput != 0)
        {
            float rotation = horizontalInput * turnSpeed * Time.deltaTime;
            rb.rotation -= rotation;
        }
    }
}
