using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int maxHealthEnemy = 2000;
    public int currentHealthEnemy;
    [Header("Damage")]
    [SerializeField] private int damageEnemy;
    [Header("Player")]
    public PlayerMain player;

    /*private void Start()
    {
        currentHealthEnemy = maxHealthEnemy;
        damageToPlayer();
    }*/

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
