using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private Animator weaponAnimator;

    // Add a flag to check if the fire animation is currently playing
    private bool isFiring = false;

    void Start()
    {
        // Get the Animator component attached to the weapon GameObject
        weaponAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for left mouse button press
        if (Input.GetButtonDown("Fire1") && !isFiring)
        {
            // Set the flag to indicate that the fire animation is playing
            isFiring = true;

            // Trigger the fire animation
            weaponAnimator.SetBool("IsFiring", true);
        }

        // Check for left mouse button release
        if (Input.GetButtonUp("Fire1") && isFiring)
        {
            // Set the flag to indicate that the fire animation is no longer playing
            isFiring = false;

            // Stop the fire animation by setting the corresponding boolean parameter to false
            weaponAnimator.SetBool("IsFiring", false);
        }
    }
}
