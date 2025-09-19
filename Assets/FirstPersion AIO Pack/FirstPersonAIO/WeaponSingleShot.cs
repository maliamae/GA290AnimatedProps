using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSingleShot : MonoBehaviour
{
    private Animator weaponAnimator;

    void Start()
    {
        // Get the Animator component attached to the weapon GameObject
        weaponAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetButtonDown("Fire1"))
        {
            // Trigger the fire animation
            weaponAnimator.SetTrigger("Fire");
        }
    }
}
