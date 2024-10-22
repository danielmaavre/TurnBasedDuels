using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnManager : MonoBehaviour
{

    [SerializeField] PlayerManager player;
    [SerializeField] PlayerManager enemy;
    [SerializeField] ActionManager actionManager;

    public bool isTurnRunning = false;
    int playerTurn;
    int enemyTurn;

    void Update()
    {
        
        if(!isTurnRunning && player.tookAction && enemy.tookAction)
        {
            Debug.Log("Executing Turn");
            ExecuteTurn();
        }
        
    }

    private void ExecuteTurn()
    {
        isTurnRunning = true;
        CheckPriority(player.GetSpeed(),enemy.GetSpeed());
        //ExecuteAction();
        //ExecuteAction();
    }

    private void CheckPriority(float playerSpeed, float enemySpeed)
    {
        if(playerSpeed > enemySpeed)
        {
            playerTurn = 1;
            enemyTurn = 2;
            Debug.Log("Player first");
        }
        else if(enemySpeed > playerSpeed)
        {
            enemyTurn = 1;
            playerTurn = 2;
            Debug.Log("Enemy first");
        }
        else if(enemySpeed == playerSpeed)
        {
            if(UnityEngine.Random.value < 0.5f)
            {
                enemyTurn = 1;
                playerTurn = 2;     
                Debug.Log("Enemy first");          
            }
            else
            {
                playerTurn = 1;
                enemyTurn = 2;
                Debug.Log("Player first");
            }
        }
       
    }    

    private void ExecuteAction(string action, string actor)
    {
                
    }


}
