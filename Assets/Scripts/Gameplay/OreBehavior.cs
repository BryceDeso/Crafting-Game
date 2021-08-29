using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreBehavior : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    private MeshRenderer mesh;

    public bool canCollect = true;
    private float _maxTime;
    private float _timeLeft;
    public float _defense;

    public bool[] oreType;

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

    public float CheckOreType()
    {
        float type;

        for (int i = 0; i < oreType.Length; i++)
        {
            if(oreType[i] == true)
            {
                type = i;
                return type;
            }
        }

        return -1;
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
