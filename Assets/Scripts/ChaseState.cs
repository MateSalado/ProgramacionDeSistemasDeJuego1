using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IEnemyState
{
    public void UpdateState()
    {
        Debug.Log("Chasing player");
    }
}
