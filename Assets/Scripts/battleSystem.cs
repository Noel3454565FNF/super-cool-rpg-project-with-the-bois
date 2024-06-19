using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum battleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class battleSystem : MonoBehaviour
{
    public static battleSystem Instance;

    //public GameObject playerPrefab;
    //public GameObject enemyPrefab;

    //public Transform playerBattleStation;
    //public Transform enemyBattleStation;

    public battleState currentState;

    [SerializeField] private EnemyMain enemyUnit;


    private void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else{
            Destroy(gameObject);
        }

        currentState = battleState.START;
        SetupBattle();
    }

    private void SetupBattle()
    {
        //Instantiate(playerPrefab, playerBattleStation);
        //Instantiate(enemyPrefab, enemyBattleStation);

        PlayerTurn();
    }

    public void PlayerTurn()
    {
        currentState = battleState.PLAYERTURN;
    }

    public void EnemyTurn()
    {
        currentState = battleState.ENEMYTURN;
        enemyUnit.bossTurn();
    }
}