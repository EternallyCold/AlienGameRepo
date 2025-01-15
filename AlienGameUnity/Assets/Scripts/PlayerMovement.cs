using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D physicsBody = null;

    public float speed = 4f;
    public float jumpSpeed = 10;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;
    public Joystick myJoystick = null;

    //awake is called before start
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called once per physics update
    private void FixedUpdate()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = speed * myJoystick.Horizontal;

        physicsBody.velocity = newVelocity;
    }

    public void MoveLeft()
    {
        //physicsBody.velocity.x = -1;

        //make a variable to hold our velocity
        //get velocity from rigedbody

        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -speed;

        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        //physicsBody.velocity.x = 1;

        //make a variable to hold our velocity
        //get velocity from rigedbody

        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = speed;

        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            Vector2 newVelocity = physicsBody.velocity;
            newVelocity.y = jumpSpeed;
            physicsBody.velocity = newVelocity;
        }
        
    }
}
