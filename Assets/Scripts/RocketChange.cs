using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketChange : MonoBehaviour
{
    private IWeapon weapon = new RocketLauncher();
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var playerController = other.GetComponent<PlayerController>();

            playerController.SetWeapon(weapon);
        }
    }
}
