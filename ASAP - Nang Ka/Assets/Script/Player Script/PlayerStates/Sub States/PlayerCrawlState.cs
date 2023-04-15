using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrawlState : PlayerGroundedState
{
    public PlayerCrawlState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
