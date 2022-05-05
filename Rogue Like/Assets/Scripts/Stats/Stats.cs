using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{

    [SerializeField]
    private int baseValue;

    private List<int> modifiers = new List<int>();

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

    public void AddModifier (int modifier)
    {
        if (modifier != 0)
        {
            modifiers.Add(modifier);
        }
    }

    public void RemoveModifier (int modifier)
    {
        if (modifier != 0)
        {
            modifiers.Remove(modifier);
        }
    }

}
