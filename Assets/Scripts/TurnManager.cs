using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnManager : MonoBehaviour
{

    [SerializeField] GameObject playerPrefab;
    [SerializeField] GameObject enemyPrefab;
    PlayerManager playerManager;
    PlayerManager enemyManager;
    ActionManager actionManager;

    //Possible battle states    
    public enum BattleStates {START, PLAYERTURN, ENEMYTURN, WON, LOST}
    //Current battle state
    public BattleStates battleState;

    private void Start() {
        actionManager = GetComponent<ActionManager>();
        InstantiatePlayerEnemy();
        battleState = BattleStates.START;
    }

    private void Update() {
          
        //Takes action according to current battle state
        switch (battleState)
        {
            case BattleStates.START:
                CheckPriority(playerManager.speed, enemyManager.speed);
                break;
            case BattleStates.PLAYERTURN:
                Debug.Log("Player Turn");
                actionManager.TakeAction(playerManager,enemyManager);                
                break;
            case BattleStates.ENEMYTURN:
                Debug.Log("Enemy Turn");
                actionManager.TakeAction(enemyManager,playerManager);
                break;
            case BattleStates.WON:
                break;
            case BattleStates.LOST:
                break;                                                                
            default:
                battleState = BattleStates.START;
                break;
        }        
    }   

    //First instantiate player and enemy
    private void InstantiatePlayerEnemy()
    {
        GameObject player = Instantiate(playerPrefab);
        playerManager = player.GetComponent<PlayerManager>();
        playerManager.fighterName = "Player";
        GameObject enemy = Instantiate(enemyPrefab);
        enemyManager  = enemy.GetComponent<PlayerManager>();
        enemyManager.fighterName = "Enemy";
    }

    private void CheckPriority(float playerSpeed, float enemySpeed)
    {
        if(playerSpeed > enemySpeed)
        {
            battleState = BattleStates.PLAYERTURN;            
        }
        else if(enemySpeed > playerSpeed)
        {
            battleState = BattleStates.ENEMYTURN;
        }
        else if(enemySpeed == playerSpeed)
        {
            if(UnityEngine.Random.value < 0.5f)
            {
                battleState = BattleStates.PLAYERTURN;         
            }
            else
            {
                battleState = BattleStates.ENEMYTURN;
            }
        }
    }   
}