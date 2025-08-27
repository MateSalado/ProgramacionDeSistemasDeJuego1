using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistChange : MonoBehaviour
{
    public PlayerController player;
    private IWeapon weapon = new Fist();
    public void OnTriggerEnter(Collider other)
    {
        player.SetWeapon(weapon);
    }
}
