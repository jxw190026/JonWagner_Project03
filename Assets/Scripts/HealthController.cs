using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] Slider _healthBar;
    [SerializeField] int _maxHealth = 100;

    public float CurrentHealth;

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    private void Update()
    {
        _healthBar.maxValue = _maxHealth;
        _healthBar.value = CurrentHealth;
            
    }


}
