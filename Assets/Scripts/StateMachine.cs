using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private IEnemyState currentState;
    private PatrolState patrolState = new PatrolState();
    private ChaseState chaseState = new ChaseState();
    private AttackState attackState = new AttackState();

    public bool playerInChaseRange = false;
    public bool playerInAttackRange = false;

    private void Start()
    {
        currentState = patrolState;
    }

    private void Update()
    {
        DetermineState();
        currentState.UpdateState();
    }

    private void DetermineState()
    {
        if (playerInAttackRange)
        {
            ChangeState(attackState);
        }
        else if (playerInChaseRange)
        {
            ChangeState(chaseState);
        }
        else
        {
            ChangeState(patrolState);
        }
    }

    private void ChangeState(IEnemyState state)
    {
        if (currentState != state) 
        {
            currentState = state;
        }
    }


}
