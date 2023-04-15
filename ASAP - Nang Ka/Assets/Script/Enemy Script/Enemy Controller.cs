using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
public class EnemyController : MonoBehaviour
{
   
    private enum State
    {
        walking,knockback,dead
    }

    private State currentState;

    [SerializeField] private Transform groundCheck, wallCheck;
    [SerializeField] private LayerMask whatisGround;
    [SerializeField] private float groundcheckDistance, wallCheckDistance;
    private bool groundisDetected, wallisDetected;

    private GameObject alive;
    private Rigidbody2D rb;
    private int facingDirection;

    private void Flip()
    {
        facingDirection *= -1;
        alive.transform.Rotate(0.0f, 180.0f, 0.0f);

    }

    private void Start()
    {
        alive = transform.Find("Alive").gameObject; 
    }

    private void Update()
    {
        switch(currentState)
        {
            case State.walking:
                 updateWalkingState();
                 break;

            case State.knockback:
                 updateKnockbackState();
                 break;

        }
    }

    //walking state
    private void walkingState()
    {

    }

    private void updateWalkingState()
    {
        groundisDetected = Physics2D.Raycast(groundCheck.position, Vector2.down, groundcheckDistance, whatisGround);
        wallisDetected = Physics2D.Raycast(wallCheck.position, Vector2.down, wallCheckDistance, whatisGround);

        if (!groundisDetected || wallisDetected)
        {
            Flip();
        }
        else
        {
            //move
        }
    }

    private void exitWalkingState()
    {

    }

    //-- Knockback State

    private void knockbackState()
    {

    }

    private void updateKnockbackState()
    {

    }

    private void exitKnockbackState()
    {
        
    }
    //-- OTHER FUNCTIONS

    private void SwitchState(State state)
    {
        switch(currentState)
        {
            case State.walking:
                 exitWalkingState();
                 break;
            case State.knockback:
                 exitKnockbackState();
                 break;
     
        }

        switch (state)
        {
            case State.walking:
                enterWalkingState();
                break;
            case State.knockback:
                enterKnockbackState();
                break;

        }

        currentState = state;
    }
}
*/