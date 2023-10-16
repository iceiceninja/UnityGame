using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SwordAttack : MonoBehaviour, IAttack
{
    [SerializeField] public float damage = 10;

    public void Attack(Vector2 center, Vector2 halfExtents, float? angle, LayerMask mask)//float damage, 
    {
        
        //this.damage = damage;
        Collider2D[] hitColliders = Physics2D.OverlapBoxAll(center,halfExtents,angle == null ? 0 : (float)angle, mask);
        foreach (Collider2D collider in hitColliders)
        {
            //Have all controllers extend a general controller that we can grab stuff by here?
            Health targetHealth = collider.GetComponent<Health>();
            if (targetHealth != null) { targetHealth.Damage(damage); }
        }
    }
}
