using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{

    private int temp;
    private int health;



    public int Temp
    {
        get
        {
            return temp;
        }

        set
        {
            temp = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        temp = 0;
        health = 3;

        EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;

    }

    void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {

    }

}