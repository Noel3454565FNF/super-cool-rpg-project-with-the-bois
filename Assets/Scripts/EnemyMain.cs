using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMain : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int maxHealthEnemy = 20000;
    public int currentHealthEnemy;
    [Header("Damage")]
    [SerializeField] private int damageEnemy;
    [Header("Player")]
    public PlayerMain player;

    public Slider slider;


    public void Update()
    {
        slider.value = (float)currentHealthEnemy / (float)maxHealthEnemy;
    }
    private void Start()
    {
        currentHealthEnemy = maxHealthEnemy;
    }
    public void bossTurn()
    {
        if (currentHealthEnemy > 10000)
            damageToPlayer();
        else if (currentHealthEnemy > 3000)
            damageToPlayerFOIS2();
        else
            HealBoss();
    }
    public void damageToPlayer()
    {
        damageEnemy = Random.Range(150, 201);
        
        player.TakeDamage(damageEnemy);
        print("L'ennemi ta mis:" + damageEnemy);
        print(player.currentHealthPlayer);
        if (player.currentHealthPlayer <= 0)
        {
         //victoire
        }
        else
        {
            
        }
    }
    public void damageToPlayerFOIS2()
    {
        damageEnemy = Random.Range(300, 401);
        
        player.TakeDamage(damageEnemy);
        print("L'ennemi ta mis:" + damageEnemy);
        print(player.currentHealthPlayer);
        if (player.currentHealthPlayer <= 0)
        {
         //victoire
        }
        else
        {
            
        }
    }
    public void HealBoss()
    {
        int healBoss;
        healBoss = Random.Range(300,1001);
        currentHealthEnemy += healBoss;
        if (currentHealthEnemy > maxHealthEnemy)
            currentHealthEnemy = maxHealthEnemy;
    }
    public void TakeDamage(int damage)
    {
        currentHealthEnemy -= damage;
        if(currentHealthEnemy <= 0)
        {
            //stopper le jeu
        }
        else
        {
            //passer à la phase suivante
        }
    }


}
