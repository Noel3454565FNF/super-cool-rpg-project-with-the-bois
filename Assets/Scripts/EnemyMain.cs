using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMain : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int maxHealthEnemy = 20000;
    public int currentHealthEnemy;
    
    private int damageEnemy;
    [Header("Player")]
    public PlayerMain player;

    public Slider slider;

    [SerializeField] private ANIMMANAGER enemyAnim;


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
        if (currentHealthEnemy > 10000) StartCoroutine(damageToPlayer(1));

        else if (currentHealthEnemy > 3000) StartCoroutine(damageToPlayer(2));

        else
        {
            StartCoroutine(HealBoss());
            StartCoroutine(damageToPlayer(3));
        }
            

    }

    public IEnumerator damageToPlayer(int multiplier)
    {
        yield return new WaitForSeconds(2f);

        StartCoroutine(enemyAnim.attackAnim());

        yield return new WaitForSeconds(1.5f);

        damageEnemy = Random.Range(101 * multiplier, 151 * multiplier);
        
        player.TakeDamage(damageEnemy);
    }

    public IEnumerator HealBoss()
    {
        yield return new WaitForSeconds(1f);

        int healBoss;
        healBoss = Random.Range(200,401);
        currentHealthEnemy += healBoss;
        if (currentHealthEnemy > maxHealthEnemy)
            currentHealthEnemy = maxHealthEnemy;

        battleSystem.Instance.PlayerTurn();
    }
    public void TakeDamage(int damage)
    {
        StartCoroutine(enemyAnim.damageAnim());

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
