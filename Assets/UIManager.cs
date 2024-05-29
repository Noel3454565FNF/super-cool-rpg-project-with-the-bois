using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI8Manager : MonoBehaviour
{

    public int maxHealth = 100;
    private int currentHealth;
    public Health playerHealth;
    public Health bossHealth;
    public int playerAttackDamage = 10;
    public int bossAttackDamage = 15;
    public float attackInterval = 1.0f;
    public float nextAttackTime;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    private void Die()
    {
        // Logique de mort (désactivation du GameObject, animation de mort, etc.)
        Debug.Log($"{gameObject.name} est mort.");
        Destroy(gameObject); // ou toute autre logique de mort appropriée
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerAttack();
                nextAttackTime = Time.time + attackInterval;
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                BossAttack();
                nextAttackTime = Time.time + attackInterval;
            }
        }
    }

    void PlayerAttack()
    {
        if (bossHealth != null)
        {
            bossHealth.TakeDamage(playerAttackDamage);
            Debug.Log("Le joueur attaque le boss.");
        }
    }

    void BossAttack()
    {
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(bossAttackDamage);
            Debug.Log("Le boss attaque le joueur.");
        }
    }
}

