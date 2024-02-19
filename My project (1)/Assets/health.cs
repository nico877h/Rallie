using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    
    public int maxHealth = 100;
    public int currentHealth;

    public healthbar healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "trees")
        {
            TakeDamage(20);
        }
    
    
    void TakeDamage(int damage)
        {
            currentHealth -= damage;

            healthbar.SetHealth(currentHealth);
        }
    }

}
