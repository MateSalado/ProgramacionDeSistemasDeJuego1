using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assault : IWeapon
{
    public string Name => "Assault Rifle";

    public void Attack()
    {
        Debug.Log("Pam!");
    }
}
