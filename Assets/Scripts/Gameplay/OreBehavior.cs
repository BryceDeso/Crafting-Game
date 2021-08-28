using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreBehavior : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    private MeshRenderer mesh;

    public bool canCollect = true;
    public float _maxTime;
    public float _timeLeft;

    private void Start()
    {
        canCollect = true;
        _timeLeft = _maxTime;
        currentHealth = maxHealth;
        mesh = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        CheckIfCollected();
    }

    private void CheckIfCollected()
    {
        if (currentHealth <= 0)
        {
            canCollect = false;
            mesh.enabled = false;
            Timer();
        }
    }

    private void Timer()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            _timeLeft = _maxTime;
            mesh.enabled = true;
            currentHealth = maxHealth;
            canCollect = true;
        }
    }
}
