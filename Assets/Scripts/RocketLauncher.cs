using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : IWeapon
{
    public string Name => "Rocket Launcher";

    public void Attack()
    {
        Debug.Log("Boom!");
    }
}
