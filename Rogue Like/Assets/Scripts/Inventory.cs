using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    #region Singleton

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }

    #endregion

    private delegate void OnItemChanged();
    private OnItemChanged onItemChangedCallBack;

    private int space = 1;

    [SerializeField]
    private List<Item> items = new List<Item>();

    public bool Add (Item item)
    {
        if (!item.IsDefaultItem)
        {
            if (items.Count >= space)
            {
                Replace(item);
                /*
                Debug.Log("Not enough room.");
                return false;
                */
            }

            items.Add(item);

            item.Use();

            if (onItemChangedCallBack != null)
            {
                onItemChangedCallBack.Invoke();
            }
        }

        return true;
    }

    public void Remove (Item item)
    {
        // Here you add code to spawn new prefab of the old Item equiped
        
        items.Remove(item);

        if (onItemChangedCallBack != null)
        {
            onItemChangedCallBack.Invoke();
        }
    }

    public void Replace (Item item)
    {
        items.Remove(item);
        items.Add(item);
    }
}
