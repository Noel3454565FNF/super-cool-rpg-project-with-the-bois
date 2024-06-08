using System;
using UnityEngine.UI;

public class Health
{
    public Health playerHealth;
    public Health bossHealth;
    public Slider playerHealthSlider;
    public Slider bossHealthSlider;
    private float maxHealth;

    void Update()
    {
        playerHealthSlider.value = (float)playerHealth.GetCurrentHealth() / playerHealth.maxHealth;
        bossHealthSlider.value = (float)bossHealth.GetCurrentHealth() / bossHealth.maxHealth;
    }

    private float GetCurrentHealth()
    {
        throw new NotImplementedException();
    }

    internal void TakeDamage(int bossAttackDamage)
    {
        throw new NotImplementedException();
    }
}