using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulletRigidbody;
    private CharacterCombat combat;

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        combat = GetComponent<CharacterCombat>();
    }

    // Start is called before the first frame update
    void Start()
    {
        float speed = 100f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            CharacterStats targetStats = other.GetComponent<CharacterStats>();
            combat.ProjectileAttack(targetStats);
        }

        Destroy(gameObject);
    }
}
