using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton

    public static EquipmentManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    [SerializeField]
    private Equipment currentEquipment;

    public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
    public OnEquipmentChanged onEquipmentChanged;

    private Inventory inventory;

    private void Start()
    {
        inventory = Inventory.instance;
    }

    public void Equip (Equipment newItem)
    {
        
        Equipment oldItem = null;

        if (currentEquipment != null)
        {
            oldItem = currentEquipment;
        }

        if (onEquipmentChanged != null)
        {
            onEquipmentChanged.Invoke(newItem, oldItem);
        }

        currentEquipment = newItem;
    }

}
