using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{

    // Start is called before the first frame update
    void Start()
    {

        EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;

    }

    void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {
        if (newItem != null)
        {
            Damage.AddModifier(newItem.DamageModifier);
        }
        /*
        if (oldItem != null)
        {
            Damage.RemoveModifier(oldItem.DamageModifier);
        }
        */
    }

    public override void Die()
    {
        base.Die();
        PlayerManager.instance.KillPlayer(); // Kill the player
    }

}
