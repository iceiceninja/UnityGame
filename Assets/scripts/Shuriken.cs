using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour, IProjectile
{
    public float getDamage()
    {
        return 10f;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Health health = collision.gameObject.GetComponent<Health>();
    //    if (health != null)
    //    {
    //        health.Damage(10);
    //        Destroy(gameObject); // Destroy the shuriken after hitting an enemy
    //    }
    //    Destroy(gameObject,2f);
    //}
}
