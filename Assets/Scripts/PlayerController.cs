using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private IWeapon weapon;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(horizontal * Time.deltaTime * speed, 0f, vertical * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            weapon.Attack();
        }
    }

    public void SetWeapon(IWeapon w)
    {
        weapon = w;
        Debug.Log($"Selected weapon: {weapon.Name}");
    }

}