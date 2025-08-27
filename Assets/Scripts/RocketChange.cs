using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketChange : MonoBehaviour
{
    public PlayerController player;
    private IWeapon weapon = new RocketLauncher();
    public void OnTriggerEnter(Collider other)
    {
        player.SetWeapon(weapon);
    }
}
