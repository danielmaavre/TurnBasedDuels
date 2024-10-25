using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    TurnManager turnManager;

    private void Start() {
        turnManager = GetComponent<TurnManager>();
        
    }

    public void TakeAction(PlayerManager source, PlayerManager target, int action){

        switch (action)
        {
            case 1:
                NormalAtack(source,target);
                break;
            case 2:
                Defend(source);
                break;
            case 3:
                Heal(source);
                break;                                
            default:                
                turnManager.battleState = TurnManager.BattleStates.START;
                Debug.Log("Default");
                break;
        }        
    }

    void NormalAtack(PlayerManager source, PlayerManager target)
    {
        Debug.Log(source.fighterName+" attacked "+target.fighterName);
        source.action = 0;
        turnManager.battleState = TurnManager.BattleStates.START;
    }

    void Defend(PlayerManager source)
    {
        Debug.Log(source.fighterName+" is defending!");
        source.action = 0;
        turnManager.battleState = TurnManager.BattleStates.START;
    }

    void Heal(PlayerManager source)
    {
        Debug.Log(source.fighterName+" has healed!");   
        source.action = 0;
        turnManager.battleState = TurnManager.BattleStates.START;
    }
}
