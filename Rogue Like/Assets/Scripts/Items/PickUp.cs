using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    private Item item;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            // Debug.Log("Picking up" + item.Name);
            bool wasPickedUp = Inventory.instance.Add(item);
                        
            if (wasPickedUp)
            {
                Destroy(this.gameObject);
            }
            
        }
    }

}
