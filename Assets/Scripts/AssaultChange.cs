using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultChange : MonoBehaviour
{
    public PlayerController player;
    private IWeapon weapon = new Assault();
    public void OnTriggerEnter(Collider other)
    {
        player.SetWeapon(weapon);
    }
}
