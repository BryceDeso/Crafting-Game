using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;
    [SerializeField]
    private float _currentHealth;
    [SerializeField]
    private float _armor;
    [SerializeField]
    private bool canBeHit = true;

    [SerializeField]
    private PlayerHitBoxBehavior _hitbox;

    [SerializeField]
    private InteractableFieldBehavior _interactionField;

    [SerializeField]
    private float _ironHeld;

    public float _invincibleTime;
    public float _timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = _health;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerActions();
    }

    private void PlayerActions()
    {
        Fighting();
        Mining();
        TakeDamage();
    }

    private void Mining()
    {
        if(_interactionField.canInteract == true)
        {
            if (_interactionField.interactable.CompareTag("IronOre") && _interactionField.ore.canCollect == true)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    _ironHeld++;
                    _interactionField.ore.currentHealth -= 1;
                }
            }
        }
    }

    private void Fighting()
    {
        if(_interactionField.canInteract == true)
        {
            if (_interactionField.interactable.CompareTag("GroundEnemy"))
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    _interactionField.groundEnemy.health -= 1;
                }
            }
        }
    }

    private void TakeDamage()
    {
        if(_hitbox.isHit == true && canBeHit == true)
        {
            if(_hitbox.enemy.CompareTag("GroundEnemy"))
            {
                float damageTaken = _hitbox.enemy.GetComponent<GroundEnemyAIBehavior>().damage - _armor;
                _currentHealth -= damageTaken;
                canBeHit = false;
            }
        }

        if(canBeHit == false)
        {
            Timer();
        }
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
        }
    }

    private void Timer()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            canBeHit = true;
            _timeLeft = _invincibleTime;
        }
    }
}