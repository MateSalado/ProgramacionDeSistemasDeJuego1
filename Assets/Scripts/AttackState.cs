using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IEnemyState
{
    public void UpdateState()
    {
        Debug.Log("Attacking player");
    }
}
