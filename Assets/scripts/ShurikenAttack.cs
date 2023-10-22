using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenAttack : MonoBehaviour, IAttack
{
    public GameObject projectilePrefab; // The shuriken or projectile prefab
    public float projectileSpeed = 10.0f;
    public float damage = 10.0f;

    private void Start()
    {
        projectilePrefab = Resources.Load<GameObject>("Shuriken");
    }
    public void Attack(Vector2 center, Vector2 halfExtents, float? angle, LayerMask mask)
    {
        GameObject projectile = Instantiate(projectilePrefab, new Vector2(transform.position.x + (1f * transform.localScale.x), transform.position.y), Quaternion.identity);
        //ProjectileController projectileComp = projectile.GetComponent<ProjectileController>();
        Collider2D collider = projectile.GetComponent<Collider2D>();
        
        // Get the rigidbody of the projectile
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        // Set the projectile's direction based on the player/enemy's facing direction
        //Vector2 direction = (gameObject.transform.position).normalized;

        // Apply force to the projectile in the specified direction
        rb.velocity = new Vector2(gameObject.transform.localScale.x * projectileSpeed,rb.velocity.y+3);
    }

}
