using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreBehavior : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public bool canCollect = true;
    public float _maxTime;
    public float _timeLeft;
    public float _timeInterval;

    private void Start()
    {
        canCollect = true;
        _timeInterval = _maxTime;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        OreCollected();
    }

    private void OreCollected()
    {
        if (currentHealth <= 0)
        {
            canCollect = false;
            Timer();
        }
    }

    private void Timer()
    {
        _maxTime -= Time.deltaTime;
        _timeLeft = _maxTime;

        if (_timeLeft <= 0)
        {
            currentHealth = maxHealth;
            canCollect = true;
            _maxTime = _timeInterval;
        }

    }
}
