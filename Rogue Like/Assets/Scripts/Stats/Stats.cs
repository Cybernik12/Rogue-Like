using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{

    [SerializeField] private int baseValue = 1;
    private int damage = 1;

    public int IDamage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    public void AddModifier (int newModifier)
    {
        damage = newModifier;
    }

    public void RemoveModifier (int oldModifier)
    {
        damage = oldModifier;
    }

}
