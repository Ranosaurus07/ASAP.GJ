using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveState : State
{
    protected E_MoveState StateData;

    protected bool isDetectingWall;
    protected bool isDetectingLedge;
    public EnemyMoveState(Entity entity, FiniteStateMachine stateMachine, string animboolname, E_MoveState StateData) : base(entity, stateMachine, animboolname)
    {
        this.StateData = StateData;
    }

    public override void Enter()
    {
        base.Enter();
        entity.SetVelocity(StateData.movementSpeed);

        isDetectingLedge = entity.CheckLedge();
        isDetectingWall = entity.CheckWall();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        isDetectingLedge = entity.CheckLedge();
        isDetectingWall = entity.CheckWall();
    }
}
