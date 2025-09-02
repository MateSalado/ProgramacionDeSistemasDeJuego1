using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : IEnemyState
{
    public void UpdateState()
    {
        Debug.Log("Patrolling");
    }
}
