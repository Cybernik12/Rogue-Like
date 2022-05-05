using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private float radius = 3f;

    private Transform player;

    private bool hasInteracted = false;

    private void Update()
    {
        if (hasInteracted == false)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                hasInteracted = true;
            }
        }

        else
        {
            hasInteracted = false;
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
