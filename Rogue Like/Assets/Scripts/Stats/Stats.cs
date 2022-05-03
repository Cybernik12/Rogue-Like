using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{

    [SerializeField]
    private int baseValue;

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

}
