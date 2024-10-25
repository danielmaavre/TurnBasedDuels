using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    

    [Header("Stats")]
    [SerializeField] Slider hpSlider;
    public string fighterName;
    public float maxHP = 50f;
    public float currentHP = 50f;
    public float maxBlock = 30f;
    public float atack = 10f;
    public float defense = 0f;
    public float speed = 5f;

    [Header("TurnInfo")]
    public int action = 0;

}
