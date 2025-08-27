using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : IWeapon
{
    public string Name => "Fists";

    public void Attack()
    {
        Debug.Log("Jupish!");
    }
}
