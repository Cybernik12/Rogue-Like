using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{

    [SerializeField]
    private int baseValue = 1;

    public int BaseValue
    {
        get
        {
            return baseValue;
        }

        set
        {
            baseValue = value;
        }
    }

    public void AddModifier (int newModifier)
    {
        baseValue = newModifier;
    }

    public void RemoveModifier (int oldModifier)
    {
        baseValue = oldModifier;
    }

}
