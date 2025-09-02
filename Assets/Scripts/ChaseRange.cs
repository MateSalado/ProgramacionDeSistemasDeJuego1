using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseRange : MonoBehaviour
{
    [SerializeField] StateMachine StateMachine;

    void Start()
    {
        StateMachine = GetComponentInParent<StateMachine>();
        if (StateMachine == null )
        {
            Debug.Log("No state machine detected! >:(");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && StateMachine != null)
        {
            StateMachine.playerInChaseRange = true;
            Debug.Log("Found!!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && StateMachine != null)
        {
            StateMachine.playerInChaseRange = false;
            Debug.Log("Lost...");
        }
    }
}
