using System;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using UnityEngine;

public abstract class StateMachine : NetworkBehaviour
{
    private State _currentState;

    private void Update()
    {
        _currentState?.Tick(Time.deltaTime);
    }

    public void SwitchState(State newState)
    {
        _currentState?.Exit();
        _currentState = newState;
        newState?.Enter();
    }

    public void MovementUpdate(
        MoveData moveData,
        bool asServer,
        bool replaying = false
    )
    {
        _currentState?.MovementUpdate(moveData, asServer, replaying);
    }
}
