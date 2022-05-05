using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    [SerializeField]
    private int damageModifier;

    public int DamageModifier
    {
        get
        {
            return damageModifier;
        }

        set
        {
            damageModifier = value;
        }
    }

    public override void Use()
    {
        base.Use();

        EquipmentManager.instance.Equip(this);
    }

}
