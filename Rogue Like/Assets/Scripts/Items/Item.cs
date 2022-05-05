using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    [SerializeField]
    new private string name = "New Item";

    [SerializeField]
    private Sprite icon = null;

    [SerializeField]
    private bool isDefaultItem = false;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;
        }

        set
        {
            icon = value;
        }
    }

    public bool IsDefaultItem
    {
        get
        {
            return isDefaultItem;
        }

        set
        {
            isDefaultItem = value;
        }
    }

    public virtual void Use()
    {
        // Use the item
        // Something might happen

        Debug.Log("Using " + name);
    }
}
