using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{


    Rigidbody2D body;
    public GameObject bullet;
    float horizontal;

    public float runSpeed;

    void Start ()
    {
       body = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
       horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
       body.velocity = new Vector2(horizontal * runSpeed, 0);
    }
}
