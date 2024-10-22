using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float maxHP = 50f;
    [SerializeField] float maxBlock = 30f;
    [SerializeField] float atack = 10f;
    [SerializeField] float defense = 0f;
    [SerializeField] float speed = 5f;

    [Header("Turn")]
    public bool tookAction = false;
    public string action;

    public float GetSpeed()
    {
        return speed;
    }

    public float GetMaxHP()
    {
        return maxHP;
    }

}
