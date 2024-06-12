using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Différents états du jeu
public enum battleState { START, PLAYERTURN, ENEMYTURN, WON, LOST, PAUSE }

public class battleSystem : MonoBehaviour
{
    // Singleton
    public static battleSystem Instance;

    [Header("Enemy Setup")]
    // Variable pour le préfab de l'ennemi
    public GameObject enemyPrefab;
    // Variable pour l'emplacement initial de l'ennemi
    public Transform enemyBattleStation;

    [Header("Battle State")]
    // Variable pour gérer le current state du jeu
    public battleState currentState;

    [Header("Script References")]
    public PlayerMain player;
    public EnemyMain boss;


    // Void Start() = Lancement du jeu
    void Start()
    {
        // Recherche si Instance existe dans cette scène ou non
        if(Instance == null)
        {
            // Si il n'y en a pas, ce gameObject devient l'Instance
            Instance = this;
        }
        else{
            // Si il y a déja un gameObject Instance, supprimer ce gameObject
            Destroy(gameObject);
        }

        // Définit la variable currentState sur START
        currentState = battleState.START;
        // Appelle la fonction SetupBattle()
        SetupBattle();
    }

    // Void SetupBattle() = Initialisation du jeu (placement du joueur et de l'ennemi, ...)
    public void SetupBattle()
    {
        // Permet de placer le préfab de l'ennemi à sa position initiale au début du jeu
        Instantiate(enemyPrefab, enemyBattleStation);
    }

    public void EndWon()
    {
        currentState = battleState.WON;
    }

    public void EndLost()
    {
        currentState = battleState.LOST;
    }

    public void PlayerTurn()
    {
        currentState = battleState.PLAYERTURN;
        // Afficher buttons
    }

    public void EnemyTurn()
    {
        currentState = battleState.ENEMYTURN;
    }

    public void PauseGame()
    {
        currentState = battleState.PAUSE;
    }
}