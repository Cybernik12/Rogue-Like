using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private float radius = 3f;

    private Transform player;

    private bool hasInteracted = false;

    public virtual void Interact()
    {
        // This method is meant to be overwritten
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance <= radius && hasInteracted == false)
        {
            Interact();
            hasInteracted = true;
        }

        else if (distance > radius)
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
