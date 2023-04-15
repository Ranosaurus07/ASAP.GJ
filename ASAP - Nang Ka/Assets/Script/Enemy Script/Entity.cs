using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public E_Entity entityData;

    public FiniteStateMachine stateMachine;
    public int facingDirection {get; private set;}
    public Rigidbody2D rgbody {get; private set;}
    public Animator anim {get; private set;}
    public GameObject aliveGO {get; private set;}

    [SerializeField] private Transform wallCheck;
    [SerializeField] private Transform ledgeCheck;
    
    private Vector2 velocityWorkspace;

    public virtual void Start()
    {
        aliveGO = transform.Find("Alive").gameObject;
        rgbody = aliveGO.GetComponent<Rigidbody2D>();
        anim = aliveGO.GetComponent<Animator>();

        stateMachine = new FiniteStateMachine();
    }

    public virtual void Update()
    {
        stateMachine.currentState.LogicUpdate();
    }

    public virtual void FixedUpdate()
    {
        stateMachine.currentState.PhysicsUpdate();
    }

    public virtual void SetVelocity(float velocity)
    {
        velocityWorkspace.Set(facingDirection * velocity, rgbody.velocity.y);
        rgbody.velocity = velocityWorkspace;
    }
    
    public virtual bool CheckWall()
    {
        return Physics2D.Raycast(wallCheck.position, aliveGO.transform.right, entityData.wallCheckDistance, entityData.whatisGround);
    }

    public virtual bool CheckLedge()
    {
        return Physics2D.Raycast(ledgeCheck.position, Vector2.down, entityData.ledgeCheckDistance, entityData.whatisGround);
    }

    public virtual void Flip()
    {
        facingDirection *= -1;
        aliveGO.transform.Rotate(0f, 180f, 0f); 
    }
}
