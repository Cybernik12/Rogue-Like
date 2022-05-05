using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    private int maxHealth = 3;
    public int currentHealth { get; private set; }

    private Stats damage;

    public Stats Damage
    {
        get
        {
            return damage;
        }

        set
        {
            value = damage;
        }
    }

    private void Awake()
    {
        currentHealth = maxHealth;
        if (damage == null)
        {
            damage = new Stats();
        }
    }

    public void TakeDamege(int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue); // To make sure damage never reaches 0

        currentHealth -= damage;
        Debug.Log(transform.name + "takes" + damage + "damage");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        // Die in some way
        // This methos is meant to be overwritten

        Debug.Log(transform.name + "died");
    }
}
