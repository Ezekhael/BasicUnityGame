using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;
    private float _currentHealth;
    [SerializeField] private GameObject _deathEffect, _hitEffect;

    [SerializeField] private Healthbar _healthbar;
    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = _maxHealth;    

        _healthbar.UpdateHealthbar(_maxHealth, _currentHealth);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        _currentHealth -= Random.Range(5f, 20f);

        if(_currentHealth <= 0)
        {
            Instantiate(_deathEffect, transform.position, Quaternion.Euler(-90,0,0));
            Destroy(gameObject);
        }
        else
        {
            _healthbar.UpdateHealthbar(_maxHealth, _currentHealth);
            Instantiate(_hitEffect, transform.position, Quaternion.identity);
        }
    }
}
