using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private IWeapon currentWeapon = new Fist();

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(horizontal * Time.deltaTime * speed, 0f, vertical * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            currentWeapon.Attack();
        }
    }

    public void SetWeapon(IWeapon w)
    {
        currentWeapon = w ?? new Fist();

        Debug.Log($"Selected weapon: {currentWeapon.Name}");
    }

}