using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistChange : MonoBehaviour
{
    private IWeapon weapon = new Fist();
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var playerController = other.GetComponent<PlayerController>();

            playerController.SetWeapon(weapon);
        }
    }
}
