using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum battleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class battleSystem : MonoBehaviour
{
    public static battleSystem Instance;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public battleState currentState;

    public QTE qte;

    void Start()
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

    void SetupBattle()
    {
        Instantiate(playerPrefab, playerBattleStation);
        Instantiate(enemyPrefab, enemyBattleStation);
    }

}