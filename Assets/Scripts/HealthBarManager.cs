using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    Slider slider;
    float maxHP;
    float currentHP;

    private void Start() {
        slider = GetComponent<Slider>();
    }

    public void InitializeHealtBar(float maxHP)
    {
        this.maxHP = maxHP;
        currentHP = maxHP;
        slider.maxValue = maxHP;
        slider.value = maxHP;
    }

    public void UpdateHealthPoints(float healthUpd)
    {
        float currentHPtmp = currentHP + healthUpd;

        if(currentHPtmp < maxHP)
        {
            currentHP = maxHP;
        }
        else if(currentHPtmp > 0)
        {
            currentHP = 0;
        }else
        {
            currentHP = currentHPtmp;            
        }
        
        slider.value = currentHP;
        
    }
}
