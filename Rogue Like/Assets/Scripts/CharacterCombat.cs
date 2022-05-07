using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    [SerializeField] private float attackSpeed = 1f;
    private float attackCooldown = 0f;

    [SerializeField] private float attackDelay = 0.6f;

    private float meleeRange;

    public event System.Action OnAttack;

    CharacterStats myStats;

    // Start is called before the first frame update
    void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= Time.deltaTime;
    }

    public void Attack (CharacterStats targetStats)
    {
        if (attackCooldown <= 0f)
        {
            targetStats.TakeDamege(myStats.Damage.IDamage); // Temporary
            // StartCoroutine(DoDamage(targetStats, attackDelay));

            if (OnAttack != null)
            {
                OnAttack();
            }

            attackCooldown = 1f / attackSpeed;
        }
    }

    IEnumerable DoDamage (CharacterStats stats, float delay)
    {
        yield return new WaitForSeconds(delay);

        stats.TakeDamege(myStats.Damage.IDamage);
    }

    public void ProjectileAttack(CharacterStats targetStats)
    {
        Attack(targetStats);
    }
}
