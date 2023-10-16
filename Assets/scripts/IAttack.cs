using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack
{
    void Attack(Vector2 center, Vector2 halfExtents, float? angle, LayerMask mask);
}

