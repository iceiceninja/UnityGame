using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public bool hurtPlayer = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health health = null;
        string layername = LayerMask.LayerToName(collision.gameObject.layer);
        bool isDefaultLayer = layername.Equals("Default");
        if (hurtPlayer || !isDefaultLayer)//Player is on default. If this changes, then change logic
        {
            health = collision.gameObject.GetComponent<Health>();
        }
        if (health != null)
        {
            float damage = GetComponent<IProjectile>().getDamage();
            health.Damage(damage);
            Destroy(gameObject);
        }
        Destroy(gameObject, 2f);
    }
}
