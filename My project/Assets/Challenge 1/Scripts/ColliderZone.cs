/*
 * (Luke Hensley)
 * (Challenge 1)
 * (Controls colliders)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderZone : MonoBehaviour
{

    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            GameController.score++;
        }
    }
}
