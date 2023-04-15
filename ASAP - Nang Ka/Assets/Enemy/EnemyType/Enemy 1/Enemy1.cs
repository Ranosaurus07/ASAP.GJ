using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Entity
{
    public E1_IdleState idleState {get; private set;}
    public E1_MoveState moveState {get; private set;}


    [SerializeField] private E_IdleState idleStateData;
    [SerializeField] private E_MoveState moveStateData;

    public override void Start()
    {
        base.Start();
        moveState = new E1_MoveState(this, stateMachine, "move", moveStateData, this);
        idleState = new E1_IdleState(this, stateMachine, "idle", idleStateData, this);

        stateMachine.Initialize(moveState);
    }

    public override void Update()
    {
        base.Update();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void SetVelocity(float velocity)
    {
        base.SetVelocity(velocity);
    }

    public override bool CheckWall()
    {
        return base.CheckWall();
    }

    public override bool CheckLedge()
    {
        return base.CheckLedge();
    }

    public override void Flip()
    {
        base.Flip();
    }
}
    