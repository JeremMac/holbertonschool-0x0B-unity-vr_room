using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBattery : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Battery"))
        {
            animator.SetBool("Open", true);
        }
    }

        private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Open", false);
    }
}
