using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    [SerializeField] public float maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void Damage(float damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " took " + damage + " damage");
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Implement death logic here, such as destroying the GameObject
        gameObject.SetActive(false);
    }
}
