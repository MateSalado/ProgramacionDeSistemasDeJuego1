using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string showName;
    public string Name;
    private void Awake()
    {
        Debug.Log(Name);
    }
}
